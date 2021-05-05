
namespace StudentRatingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowPoints = new System.Windows.Forms.DataGridViewButtonColumn();
            this.extraPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentRatingDbDataSet1 = new StudentRatingSystem.StudentRatingDbDataSet1();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.Specialty = new System.Windows.Forms.CheckBox();
            this.Group = new System.Windows.Forms.CheckBox();
            this.Course = new System.Windows.Forms.CheckBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.RemoveFilter = new System.Windows.Forms.Button();
            this.RatingPointCategories = new System.Windows.Forms.ComboBox();
            this.ByPoints = new System.Windows.Forms.CheckBox();
            this.SpecialtyFilter = new System.Windows.Forms.NumericUpDown();
            this.GroupFilter = new System.Windows.Forms.NumericUpDown();
            this.CourseFilter = new System.Windows.Forms.ComboBox();
            this.ChangeSubjectList = new System.Windows.Forms.Button();
            this.ImportToExcel = new System.Windows.Forms.Button();
            this.studentRatingDbDataSet = new StudentRatingSystem.StudentRatingDbDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentRatingSystem.StudentRatingDbDataSetTableAdapters.StudentsTableAdapter();
            this.studentsTableAdapter1 = new StudentRatingSystem.StudentRatingDbDataSet1TableAdapters.StudentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.allStudentCountLabel = new System.Windows.Forms.Label();
            this.showedStudentCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet1)).BeginInit();
            this.Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.ShowPoints,
            this.extraPointDataGridViewTextBoxColumn,
            this.ratingPointDataGridViewTextBoxColumn,
            this.Id});
            this.dataGridView1.DataSource = this.studentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 405);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ПІБ студента";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Група";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Width = 120;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Спеціальність";
            this.specialtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialtyDataGridViewTextBoxColumn.Width = 120;
            // 
            // ShowPoints
            // 
            this.ShowPoints.HeaderText = "Бали";
            this.ShowPoints.MinimumWidth = 6;
            this.ShowPoints.Name = "ShowPoints";
            this.ShowPoints.ReadOnly = true;
            this.ShowPoints.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowPoints.Text = "Перегляд балів";
            this.ShowPoints.ToolTipText = "Переглянути/редагувати бали";
            this.ShowPoints.UseColumnTextForButtonValue = true;
            this.ShowPoints.Width = 150;
            // 
            // extraPointDataGridViewTextBoxColumn
            // 
            this.extraPointDataGridViewTextBoxColumn.DataPropertyName = "ExtraPoint";
            this.extraPointDataGridViewTextBoxColumn.HeaderText = "Додаткові бали";
            this.extraPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.extraPointDataGridViewTextBoxColumn.Name = "extraPointDataGridViewTextBoxColumn";
            this.extraPointDataGridViewTextBoxColumn.Width = 130;
            // 
            // ratingPointDataGridViewTextBoxColumn
            // 
            this.ratingPointDataGridViewTextBoxColumn.DataPropertyName = "RatingPoint";
            this.ratingPointDataGridViewTextBoxColumn.HeaderText = "Рейтинговий бал";
            this.ratingPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingPointDataGridViewTextBoxColumn.Name = "ratingPointDataGridViewTextBoxColumn";
            this.ratingPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingPointDataGridViewTextBoxColumn.Width = 140;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.studentRatingDbDataSet1;
            // 
            // studentRatingDbDataSet1
            // 
            this.studentRatingDbDataSet1.DataSetName = "StudentRatingDbDataSet1";
            this.studentRatingDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton.Location = new System.Drawing.Point(12, 425);
            this.AddStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(207, 39);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Додати  студента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(262, 425);
            this.DeleteStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(207, 39);
            this.DeleteStudentButton.TabIndex = 2;
            this.DeleteStudentButton.Text = "Видалити студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudentButton.Location = new System.Drawing.Point(512, 425);
            this.EditStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(207, 39);
            this.EditStudentButton.TabIndex = 3;
            this.EditStudentButton.Text = "Редагувати дані";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(762, 425);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(207, 39);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Пошук за ім\'ям";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.Specialty);
            this.Filters.Controls.Add(this.Group);
            this.Filters.Controls.Add(this.Course);
            this.Filters.Controls.Add(this.FilterButton);
            this.Filters.Controls.Add(this.RemoveFilter);
            this.Filters.Controls.Add(this.RatingPointCategories);
            this.Filters.Controls.Add(this.ByPoints);
            this.Filters.Controls.Add(this.SpecialtyFilter);
            this.Filters.Controls.Add(this.GroupFilter);
            this.Filters.Controls.Add(this.CourseFilter);
            this.Filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filters.Location = new System.Drawing.Point(12, 518);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(955, 97);
            this.Filters.TabIndex = 5;
            this.Filters.TabStop = false;
            this.Filters.Text = "Фільтрувати за:";
            // 
            // Specialty
            // 
            this.Specialty.AutoSize = true;
            this.Specialty.Location = new System.Drawing.Point(356, 27);
            this.Specialty.Name = "Specialty";
            this.Specialty.Size = new System.Drawing.Size(150, 24);
            this.Specialty.TabIndex = 12;
            this.Specialty.Text = "спеціальністю";
            this.Specialty.UseVisualStyleBackColor = true;
            this.Specialty.CheckedChanged += new System.EventHandler(this.Specialty_CheckedChanged_1);
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(222, 27);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(90, 24);
            this.Group.TabIndex = 11;
            this.Group.Text = "групою";
            this.Group.UseVisualStyleBackColor = true;
            this.Group.CheckedChanged += new System.EventHandler(this.Group_CheckedChanged_1);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(7, 27);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(89, 24);
            this.Course.TabIndex = 10;
            this.Course.Text = "курсом";
            this.Course.UseVisualStyleBackColor = true;
            this.Course.CheckedChanged += new System.EventHandler(this.Course_CheckedChanged_1);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(777, 19);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(172, 32);
            this.FilterButton.TabIndex = 9;
            this.FilterButton.Text = "Застосувати";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // RemoveFilter
            // 
            this.RemoveFilter.Location = new System.Drawing.Point(777, 56);
            this.RemoveFilter.Name = "RemoveFilter";
            this.RemoveFilter.Size = new System.Drawing.Size(172, 32);
            this.RemoveFilter.TabIndex = 8;
            this.RemoveFilter.Text = "Скинути фільтр";
            this.RemoveFilter.UseVisualStyleBackColor = true;
            this.RemoveFilter.Click += new System.EventHandler(this.RemoveFilter_Click);
            // 
            // RatingPointCategories
            // 
            this.RatingPointCategories.Enabled = false;
            this.RatingPointCategories.FormattingEnabled = true;
            this.RatingPointCategories.Items.AddRange(new object[] {
            "Відмінники (всі бали 90+)",
            "Боржники (хоч один бал 60-)"});
            this.RatingPointCategories.Location = new System.Drawing.Point(529, 51);
            this.RatingPointCategories.Name = "RatingPointCategories";
            this.RatingPointCategories.Size = new System.Drawing.Size(216, 28);
            this.RatingPointCategories.TabIndex = 7;
            // 
            // ByPoints
            // 
            this.ByPoints.AutoSize = true;
            this.ByPoints.Location = new System.Drawing.Point(529, 26);
            this.ByPoints.Name = "ByPoints";
            this.ByPoints.Size = new System.Drawing.Size(120, 24);
            this.ByPoints.TabIndex = 6;
            this.ByPoints.Text = "За балами";
            this.ByPoints.UseVisualStyleBackColor = true;
            this.ByPoints.CheckedChanged += new System.EventHandler(this.ByPoints_CheckedChanged);
            // 
            // SpecialtyFilter
            // 
            this.SpecialtyFilter.Enabled = false;
            this.SpecialtyFilter.Location = new System.Drawing.Point(384, 51);
            this.SpecialtyFilter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SpecialtyFilter.Name = "SpecialtyFilter";
            this.SpecialtyFilter.Size = new System.Drawing.Size(89, 27);
            this.SpecialtyFilter.TabIndex = 5;
            // 
            // GroupFilter
            // 
            this.GroupFilter.Enabled = false;
            this.GroupFilter.Location = new System.Drawing.Point(223, 51);
            this.GroupFilter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GroupFilter.Name = "GroupFilter";
            this.GroupFilter.Size = new System.Drawing.Size(89, 27);
            this.GroupFilter.TabIndex = 4;
            // 
            // CourseFilter
            // 
            this.CourseFilter.Enabled = false;
            this.CourseFilter.FormattingEnabled = true;
            this.CourseFilter.Items.AddRange(new object[] {
            "перший",
            "другий",
            "третій",
            "четвертий",
            "п\'ятий"});
            this.CourseFilter.Location = new System.Drawing.Point(6, 51);
            this.CourseFilter.Name = "CourseFilter";
            this.CourseFilter.Size = new System.Drawing.Size(188, 28);
            this.CourseFilter.TabIndex = 3;
            // 
            // ChangeSubjectList
            // 
            this.ChangeSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSubjectList.Location = new System.Drawing.Point(12, 471);
            this.ChangeSubjectList.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSubjectList.Name = "ChangeSubjectList";
            this.ChangeSubjectList.Size = new System.Drawing.Size(207, 39);
            this.ChangeSubjectList.TabIndex = 6;
            this.ChangeSubjectList.Text = "Списки предметів";
            this.ChangeSubjectList.UseVisualStyleBackColor = true;
            this.ChangeSubjectList.Click += new System.EventHandler(this.ChangeSubjectList_Click);
            // 
            // ImportToExcel
            // 
            this.ImportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportToExcel.Location = new System.Drawing.Point(262, 471);
            this.ImportToExcel.Margin = new System.Windows.Forms.Padding(4);
            this.ImportToExcel.Name = "ImportToExcel";
            this.ImportToExcel.Size = new System.Drawing.Size(207, 39);
            this.ImportToExcel.TabIndex = 7;
            this.ImportToExcel.Text = "Вивести в Excel";
            this.ImportToExcel.UseVisualStyleBackColor = true;
            this.ImportToExcel.Click += new System.EventHandler(this.ImportToExcel_Click);
            // 
            // studentRatingDbDataSet
            // 
            this.studentRatingDbDataSet.DataSetName = "StudentRatingDbDataSet";
            this.studentRatingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentRatingDbDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(508, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кількість студентів (Відображено/всього):";
            // 
            // allStudentCountLabel
            // 
            this.allStudentCountLabel.AutoSize = true;
            this.allStudentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allStudentCountLabel.Location = new System.Drawing.Point(894, 495);
            this.allStudentCountLabel.Name = "allStudentCountLabel";
            this.allStudentCountLabel.Size = new System.Drawing.Size(78, 29);
            this.allStudentCountLabel.TabIndex = 9;
            this.allStudentCountLabel.Text = "50000";
            // 
            // showedStudentCountLabel
            // 
            this.showedStudentCountLabel.AutoSize = true;
            this.showedStudentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showedStudentCountLabel.Location = new System.Drawing.Point(798, 495);
            this.showedStudentCountLabel.Name = "showedStudentCountLabel";
            this.showedStudentCountLabel.Size = new System.Drawing.Size(78, 29);
            this.showedStudentCountLabel.TabIndex = 10;
            this.showedStudentCountLabel.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(874, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showedStudentCountLabel);
            this.Controls.Add(this.allStudentCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportToExcel);
            this.Controls.Add(this.ChangeSubjectList);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EditStudentButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Автоматизована система підрахунку рейтингу студентів";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet1)).EndInit();
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentRatingDbDataSet studentRatingDbDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentRatingDbDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private StudentRatingDbDataSet1 studentRatingDbDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private StudentRatingDbDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter1;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.ComboBox CourseFilter;
        private System.Windows.Forms.NumericUpDown GroupFilter;
        private System.Windows.Forms.Button RemoveFilter;
        private System.Windows.Forms.ComboBox RatingPointCategories;
        private System.Windows.Forms.CheckBox ByPoints;
        private System.Windows.Forms.NumericUpDown SpecialtyFilter;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button ChangeSubjectList;
        private System.Windows.Forms.Button ImportToExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allStudentCountLabel;
        private System.Windows.Forms.Label showedStudentCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox Course;
        private System.Windows.Forms.CheckBox Specialty;
        private System.Windows.Forms.CheckBox Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

