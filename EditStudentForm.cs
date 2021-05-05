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
    public partial class EditStudentForm : Form
    {
        public EditStudentForm(string name, int group, int specialty, float extraPoints=0f)
        {
            InitializeComponent();
            StudentName.Text = name;
            StudentGroupNum.Value = group;
            StudentSpecialtyNum.Value = specialty;
            ExtraPoints.Value = (decimal)extraPoints;
        }
    }
}
