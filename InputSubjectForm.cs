using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRatingSystem
{
    public partial class InputSubjectForm : Form
    {
        public InputSubjectForm()
        {
            InitializeComponent();
        }
        public InputSubjectForm(string name, float credits, int hours, string examType)
        {
            InitializeComponent();
            SubjectName.Text = name;
            Credits.Value = (decimal)credits;
            HoursCount.Value = hours;
            ExamType.Text = examType;
        }
    }
}
