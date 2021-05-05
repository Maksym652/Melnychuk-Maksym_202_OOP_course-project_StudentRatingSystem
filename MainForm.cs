using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace StudentRatingSystem
{
    public partial class MainForm : Form{
        internal StudentDbContext studDb;
        double CalculateRatingPoint(Point[] points, float extraPoint){
            if (points.All(p => p.Mark >= 60)){
                double result = 0;
                double sumOfCredits = 0;
                foreach (var point in points){
                    if (!point.FinalExamType.Contains("атестація")){
                        result += point.Credits * point.Mark;
                        sumOfCredits += point.Credits;
                    }
                }
                if (sumOfCredits != 0) result /= sumOfCredits;
                else return 0;
                result = result * 0.9 + extraPoint;
                result = Math.Round(result, 2);
                return result;
            }
            else return 0;
        }
        void RecalculateRatingPoints(int group){
            foreach (var student in studDb.Students.Where(st => st.Group == group)){
                student.RatingPoint = (float)CalculateRatingPoint(student.Points.ToArray(), student.ExtraPoint);
            }
        }
        public MainForm(){
            InitializeComponent();
            studDb = new StudentDbContext();
            studDb.Students.Load();
            studDb.Points.Load();
            allStudentCountLabel.Text = studDb.Students.Count().ToString();
            showedStudentCountLabel.Text = allStudentCountLabel.Text;
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        }
        private void MainForm_Load(object sender, EventArgs e){
            this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
        }
        private void AddStudentButton_Click(object sender, EventArgs e){
            AddStudentForm inputStudentForm = new AddStudentForm();
            while (true){
                inputStudentForm.ShowDialog();
                if (inputStudentForm.DialogResult == DialogResult.OK){
                    DialogResult dr = MessageBox.Show("Ви впевнені?", "Підтвердження внесення даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes){
                        this.Cursor = Cursors.WaitCursor;
                        if (studDb.Students.Where(st => st.Group == (int)inputStudentForm.StudentGroupNum.Value).Any()){
                            var points = studDb.Students.Where(st => st.Group == (int)inputStudentForm.StudentGroupNum.Value).FirstOrDefault().Points.ToArray();

                            studDb.Students.Add(new Student { Name = inputStudentForm.StudentName.Text, Group = (int)inputStudentForm.StudentGroupNum.Value, Specialty = (int)inputStudentForm.StudentSpecialtyNum.Value });
                            studDb.SaveChanges();
                            for (int i = 0; i < points.Length; i++){
                                studDb.Students.Where(st => st.Name == inputStudentForm.StudentName.Text && st.Group == (int)inputStudentForm.StudentGroupNum.Value && st.Specialty == (int)inputStudentForm.StudentSpecialtyNum.Value).First().Points.Add(new Point() { Subject = points[i].Subject, Credits = points[i].Credits, Hours = points[i].Hours, FinalExamType = points[i].FinalExamType });
                            }
                        }
                        else{
                            studDb.Students.Add(new Student { Name = inputStudentForm.StudentName.Text, Group = (int)inputStudentForm.StudentGroupNum.Value, Specialty = (int)inputStudentForm.StudentSpecialtyNum.Value });
                        }
                        studDb.SaveChanges();
                        this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                        allStudentCountLabel.Text = studDb.Students.Count().ToString();
                        showedStudentCountLabel.Text = (int.Parse(showedStudentCountLabel.Text) + 1).ToString();
                        this.Cursor = Cursors.Arrow;
                        break;
                    }
                }
                else{
                    inputStudentForm.Close();
                    break;
                }
            }
        }
        private void DeleteStudentButton_Click(object sender, EventArgs e){
            int deletedCount = dataGridView1.SelectedRows.Count;
            if (deletedCount >= 1){
                if (MessageBox.Show("Ви впевнені, що хочете видалити дані про студента(студентів)? Якщо обрано кілька - будуть видалені ВСІ!", "Підтвердження видалення даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    this.Cursor = Cursors.WaitCursor;
                    string[] deletedStudentNames = new string[dataGridView1.SelectedRows.Count];
                    int i = 0;
                    foreach (var row in dataGridView1.SelectedRows.Cast<DataGridViewRow>()){
                        deletedStudentNames[i] = (string)row.Cells[0].Value;
                        i++;
                    }
                    studDb.Points.RemoveRange(studDb.Points.Where(p => deletedStudentNames.Contains(p.Student.Name)));
                    studDb.Students.RemoveRange(studDb.Students.Where(student => deletedStudentNames.Contains(student.Name)));
                    studDb.SaveChanges();
                    this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                    allStudentCountLabel.Text = studDb.Students.Count().ToString();
                    showedStudentCountLabel.Text = (int.Parse(showedStudentCountLabel.Text) - deletedCount).ToString();
                    this.Cursor = Cursors.Arrow;
                }
            }
            else{
                this.Cursor = Cursors.WaitCursor;
                InputTextForm studentNameForm = new InputTextForm(this);
                this.Cursor = Cursors.Arrow;
                while (true){
                    studentNameForm.ShowDialog();
                    if (studentNameForm.DialogResult == DialogResult.OK){
                        if(!studDb.Students.Where(student => student.Name + " (" + student.Group.ToString() + " група)" == studentNameForm.InputString.Text).Any()){
                            MessageBox.Show("Студента з таким ім'ям немає в базі даних!\nОбирайте серед запропонованих варіантів!", "Некоректні дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        if (MessageBox.Show("Ви впевнені, що хочете видалити дані про цього студента(студентку): "+ studentNameForm.InputString.Text+" ?\nДані буде видалено назавжди!", "Видалення даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                            this.Cursor = Cursors.WaitCursor;
                            studDb.Students.Remove(studDb.Students.Where(student => student.Name + " (" + student.Group.ToString() + " група)" == studentNameForm.InputString.Text).FirstOrDefault());
                            studDb.Points.RemoveRange(studDb.Points.Where(p => p.Student.Name + " (" + p.Student.Group.ToString() + " група)" == studentNameForm.InputString.Text));
                            studDb.SaveChanges();
                            this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                            allStudentCountLabel.Text = studDb.Students.Count().ToString();
                            showedStudentCountLabel.Text = (int.Parse(showedStudentCountLabel.Text) - deletedCount).ToString();
                            this.Cursor = Cursors.Arrow;
                            break;
                        }
                    }
                    else{
                        studentNameForm.Close();
                        break;
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//редагування додаткових балів шляхом зміни значення в комірці таблиці
            if (e.ColumnIndex == 4){
                this.Cursor = Cursors.WaitCursor;
                studDb.Students.Find(dataGridView1[6, e.RowIndex].Value).ExtraPoint = (float)dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                studDb.Students.Find(dataGridView1[6, e.RowIndex].Value).RatingPoint = (float)CalculateRatingPoint(studDb.Students.Find(dataGridView1[6, e.RowIndex].Value).Points.ToArray(), studDb.Students.Find(dataGridView1[6, e.RowIndex].Value).ExtraPoint);
                studDb.SaveChanges();
                this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                this.Cursor = Cursors.Arrow;
            }
        }
        private void EditStudentButton_Click(object sender, EventArgs e){
            if (dataGridView1.SelectedRows.Count < 1){
                MessageBox.Show("Оберіть відповідний рядок в таблиці!", "Редагування даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }if (dataGridView1.SelectedRows.Count > 1){
                MessageBox.Show("Оберіть тільки один рядок!", "Редагування даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Student st = studDb.Students.Find(dataGridView1.SelectedRows[0].Cells[6].Value);
            EditStudentForm editForm = new EditStudentForm(st.Name, st.Group, st.Specialty, st.ExtraPoint);
            this.Cursor = Cursors.Arrow;
            editForm.ShowDialog();
            while (true){
                if (editForm.DialogResult == DialogResult.OK){
                    if (MessageBox.Show("Дані буде змінено. Ви впевнені?", "Підтвердження зміни даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                        this.Cursor = Cursors.WaitCursor;
                        st.Name = editForm.StudentName.Text;
                        int group = st.Group;
                        st.Group = (int)editForm.StudentGroupNum.Value;
                        st.Specialty = (int)editForm.StudentSpecialtyNum.Value;
                        st.ExtraPoint = (float)editForm.ExtraPoints.Value;
                        st.RatingPoint = (float)CalculateRatingPoint(st.Points.ToArray(), st.ExtraPoint);
                        if(st.Group != group) studDb.Points.RemoveRange(st.Points);
                        if (studDb.Students.Where(s => s.Group == (int)editForm.StudentGroupNum.Value).Any()&&st.Group!=group){
                            var points = studDb.Students.Where(s => s.Group == (int)editForm.StudentGroupNum.Value).FirstOrDefault().Points.ToArray();
                            for (int i = 0; i < points.Length; i++){
                                st.Points.Add(new Point() { Subject = points[i].Subject, Credits = points[i].Credits, Hours = points[i].Hours, FinalExamType = points[i].FinalExamType });
                            }
                        }
                        studDb.SaveChanges();
                        this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                        this.Cursor = Cursors.Arrow;
                        break;
                    }
                }
                else{
                    editForm.Close();
                    break;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e){
            if (SearchButton.Text == "Пошук за ім'ям"){
                this.Cursor = Cursors.WaitCursor;
                InputTextForm studentNameForm = new InputTextForm(this);
                this.Cursor = Cursors.Arrow;
                studentNameForm.ShowDialog();
                if (studentNameForm.DialogResult == DialogResult.OK){
                    var filteredData = studDb.Students.Local.ToBindingList().Where(student => student.Name + " (" + student.Group.ToString() + " група)" == studentNameForm.InputString.Text);
                    studDb.Students.Load();
                    dataGridView1.DataSource = filteredData.ToArray();
                    SearchButton.Text = "Відобразити всіх";
                }
                else{
                    studentNameForm.Close();
                }
            }
            else{
                studDb.Students.Load();
                dataGridView1.DataSource = studDb.Students.Local.ToBindingList();
                SearchButton.Text = "Пошук за ім'ям";
            }
            showedStudentCountLabel.Text = dataGridView1.RowCount.ToString();
        }
        private void FilterButton_Click(object sender, EventArgs e){
            var filteredData = studDb.Students.Local.Where(student => true);
            if (Course.Checked)
                filteredData = filteredData.Where(student => student.Group / 100 == CourseFilter.SelectedIndex + 1);
            if (Group.Checked)
                filteredData = filteredData.Where(student => student.Group == GroupFilter.Value);
            if (Specialty.Checked)
                filteredData = filteredData.Where(student => student.Specialty == SpecialtyFilter.Value);
            if (ByPoints.Checked){
                if (RatingPointCategories.SelectedIndex == 0){
                    filteredData = filteredData.Where(student => student.Points.All(p => p.Mark >= 90)&&student.Points.Count!=0);
                }
                else{
                    filteredData = filteredData.Where(student => !student.Points.All(p => p.Mark >= 60));
                }
            }
            dataGridView1.DataSource = new ObservableCollection<Student>(filteredData.ToList()).ToBindingList();
            showedStudentCountLabel.Text = dataGridView1.RowCount.ToString();
        }

        private void RemoveFilter_Click(object sender, EventArgs e){
            dataGridView1.DataSource = studDb.Students.Local.ToBindingList();
            Course.Checked = false;
            Group.Checked = false;
            Specialty.Checked = false;
            ByPoints.Checked = false;
            showedStudentCountLabel.Text = allStudentCountLabel.Text;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if (e.ColumnIndex == 3 && e.RowIndex!=-1){
                PointsForm pointsForm;
                while (true){
                    pointsForm = new PointsForm(dataGridView1[0, e.RowIndex].Value.ToString(), this, (int)dataGridView1[6, e.RowIndex].Value);
                    pointsForm.ShowDialog(this);
                    if (pointsForm.DialogResult == DialogResult.OK){
                        if (pointsForm.PointsTable.SelectedRows.Count != 1){
                            MessageBox.Show("Оберіть 1 предмет! Не більше і не менше!", "Редагування балів", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else{
                            int pId = (int)pointsForm.PointsTable.SelectedRows[0].Cells[5].Value;
                            studDb.Points.Find(pId).Mark = (int)pointsForm.newPoint.Value;
                            pointsForm.PointsTable.SelectedRows[0].Cells[4].Value = (int)pointsForm.newPoint.Value;
                            pointsForm = new PointsForm(dataGridView1[0, e.RowIndex].Value.ToString(), this, (int)dataGridView1[6, e.RowIndex].Value);
                            studDb.Students.Find(studDb.Points.Find(pId).Student.Id).RatingPoint = (float)pointsForm.RatingPoint;
                            studDb.SaveChanges();
                            this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
                            dataGridView1.Refresh();
                        }
                    }
                    else{
                        pointsForm.Close();
                        break;
                    }
                }
            }
        }
        private void ChangeSubjectList_Click(object sender, EventArgs e){
            InputTextForm inputGroup = new InputTextForm("Введіть групи через проміжок.", "Введення груп");
            inputGroup.ShowDialog();
            if (inputGroup.DialogResult == DialogResult.OK){
                string[] groups_str = inputGroup.InputString.Text.Split(' ');
                int[] groups = new int[groups_str.Length];
                for (int i = 0; i < groups_str.Length; i++){
                    if (!int.TryParse(groups_str[i], out groups[i])){
                        MessageBox.Show("Помилка!\nВведено нечислові дані.", "Введення груп", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                foreach(var gr in groups){
                    if(!studDb.Students.Where(st => st.Group==gr).Any()){
                        MessageBox.Show("Помилка!\nОднієї з введених груп неіснує.", "Введення груп", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (groups.Length > 1)
                    MessageBox.Show("Ви ввели кілька груп. Якщо групи мають різний набір навчальних дисциплін, то врахуйте наступне:\nДОДАВАННЯ додає предмет до списку предметів ВСІХ груп\nРЕДАГУВАННЯ і ВИДАЛЕННЯ предметів здійснюється тільки для тих груп, де вже наявні ці предмети\nВідображається список предметів першої заданої групи", "Список предметів - довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubjectsForm subjectsForm;
                while (true){
                    subjectsForm = new SubjectsForm(groups, this);
                    subjectsForm.ShowDialog();
                    if (subjectsForm.DialogResult == DialogResult.Yes){
                        InputSubjectForm addSubjectForm = new InputSubjectForm();
                        addSubjectForm.ShowDialog();
                        if (addSubjectForm.DialogResult == DialogResult.OK){
                            if (MessageBox.Show("Ви впевнені?", "Додання предмета", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                                foreach (var student in studDb.Students.Where(student => groups.Contains(student.Group))){
                                    student.Points.Add(new Point { Subject = addSubjectForm.SubjectName.Text, Credits = (float)addSubjectForm.Credits.Value, Hours = (int)addSubjectForm.HoursCount.Value, FinalExamType = (string)addSubjectForm.ExamType.SelectedItem });
                                }
                                foreach(var group in groups){
                                    RecalculateRatingPoints(group);
                                }
                                studDb.SaveChanges();
                            }
                        }
                    }
                    if (subjectsForm.DialogResult == DialogResult.Retry){
                        if (subjectsForm.subjectsTable.SelectedRows.Count < 1)
                            MessageBox.Show("Оберіть рядок в таблиці!", "Редагування предмету", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else{
                            if (subjectsForm.subjectsTable.SelectedRows.Count > 1)
                                MessageBox.Show("Оберіть тільки один рядок!", "Редагування предмету", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else{
                                Point p = new Point(){
                                    Subject = subjectsForm.subjectsTable.SelectedRows.Cast<DataGridViewRow>().First().Cells[0].Value.ToString(),
                                    Credits = (float)subjectsForm.subjectsTable.SelectedRows.Cast<DataGridViewRow>().First().Cells[1].Value,
                                    Hours = (int)subjectsForm.subjectsTable.SelectedRows.Cast<DataGridViewRow>().First().Cells[2].Value,
                                    FinalExamType = subjectsForm.subjectsTable.SelectedRows.Cast<DataGridViewRow>().First().Cells[3].Value.ToString()};
                                InputSubjectForm editForm = new InputSubjectForm(p.Subject, p.Credits, p.Hours, p.FinalExamType);
                                editForm.ShowDialog();
                                if (editForm.DialogResult == DialogResult.OK){
                                    if (MessageBox.Show("Ви впевнені?", "Редагування предмета", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                                        foreach (var point in studDb.Points.Where(p1 => p.Subject == p1.Subject && p.Credits == p1.Credits && p.Hours == p1.Hours && p.FinalExamType == p1.FinalExamType && groups.Contains(p1.Student.Group))){
                                            point.Subject = editForm.SubjectName.Text;
                                            point.Credits = (float)editForm.Credits.Value;
                                            point.Hours = (int)editForm.HoursCount.Value;
                                            point.FinalExamType = editForm.ExamType.Text;
                                        }
                                        foreach (var group in groups){
                                            RecalculateRatingPoints(group);
                                        }
                                        studDb.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                    if (subjectsForm.DialogResult == DialogResult.No){
                        if (MessageBox.Show("Ви впевнені? Буде видалено вибрані предмети.", "Видалення предмета", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                            string subject;
                            float credits;
                            int hours;
                            string type;
                            foreach (var row in subjectsForm.subjectsTable.SelectedRows.Cast<DataGridViewRow>()){
                                subject = row.Cells[0].Value.ToString();
                                credits = (float)row.Cells[1].Value;
                                hours = (int)row.Cells[2].Value;
                                type = row.Cells[3].Value.ToString();
                                studDb.Points.RemoveRange(studDb.Points.Where(p => (p.Subject == subject && p.Credits == credits && p.Hours == hours && p.FinalExamType == type && groups.Contains(p.Student.Group))));
                            }
                            foreach (var group in groups){
                                RecalculateRatingPoints(group);
                            }
                            studDb.SaveChanges();
                        }
                    }
                    if (subjectsForm.DialogResult == DialogResult.Cancel){
                        subjectsForm.Close();
                        break;
                    }
                }
            }
            else{
                inputGroup.Close();
            }
            this.studentsTableAdapter1.Fill(this.studentRatingDbDataSet1.Students);
        }
        private void ImportToExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK){
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                int k = 0;
                for (int i = 1; i < dataGridView1.ColumnCount; i++){
                    if (i != 4) worksheet.Rows[1].Columns[i - k] = dataGridView1.Columns[i - 1].HeaderText;
                    else k = 1;
                }
                worksheet.Columns.ColumnWidth = 15;
                worksheet.Columns[1].ColumnWidth = 35;
                k = 0;
                for (int i = 1; i <= dataGridView1.RowCount; i++){
                    for (int j = 1; j < dataGridView1.ColumnCount; j++){
                        if (j != 4){
                            worksheet.Rows[i + 1].Columns[j - k] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                        }
                        else{
                            k = 1;
                        }
                    }
                    k = 0;
                }
                workbook.SaveAs(saveFileDialog.FileName);
                excelApp.Quit();
            }
        }
        private void Course_CheckedChanged_1(object sender, EventArgs e){
            if (Course.Checked) CourseFilter.Enabled = true;
            else CourseFilter.Enabled = false;
        }
        private void Group_CheckedChanged_1(object sender, EventArgs e){
            if (Group.Checked) GroupFilter.Enabled = true;
            else GroupFilter.Enabled = false;
        }
        private void Specialty_CheckedChanged_1(object sender, EventArgs e){
            if (Specialty.Checked) SpecialtyFilter.Enabled = true;
            else SpecialtyFilter.Enabled = false;
        }
        private void ByPoints_CheckedChanged(object sender, EventArgs e){
            if (ByPoints.Checked)
                RatingPointCategories.Enabled = true;
            else
                RatingPointCategories.Enabled = false;
        }
    }
}