using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRatingSystem
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }
        public SubjectsForm(int[] groups, MainForm mf)
        {
            InitializeComponent();
            StringBuilder str = new StringBuilder(this.Text);
            foreach(var gr in groups)
            {
                str.Append(gr.ToString() + ",");
            }
            str.Remove(str.Length - 1, 1);
            this.Text = str.ToString();
            int g = groups[0];
            var thisGroupSubjects = mf.studDb.Students.Where(st => st.Group==g).First().Points;
            mf.studDb.Points.Load();
            subjectsTable.DataSource = thisGroupSubjects.ToArray();
        }
        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentRatingDbDataSet6.Points". При необходимости она может быть перемещена или удалена.
            this.pointsTableAdapter.Fill(this.studentRatingDbDataSet6.Points);
        }
    }
}
