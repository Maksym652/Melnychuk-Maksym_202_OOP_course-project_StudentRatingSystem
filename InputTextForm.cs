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
    public partial class InputTextForm : Form
    {
        public InputTextForm()
        {
            InitializeComponent();
        }
        public InputTextForm(string text, string title="Введення значення")
        {
            InitializeComponent();
            this.Text = title;
            this.label1.Text = text;
        }
        public InputTextForm(MainForm mf)
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            Student[] students = mf.studDb.Students.ToArray();
            foreach (var student in students)
            {
                source.Add(student.Name + " (" + student.Group.ToString()+" група)");
            }
            InputString.AutoCompleteCustomSource = source;
        }
    }
}
