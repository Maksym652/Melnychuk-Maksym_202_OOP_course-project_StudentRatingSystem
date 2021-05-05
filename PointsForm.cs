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
    public partial class PointsForm : Form
    {
        public double RatingPoint { get; set; }
        public PointsForm()
        {
            InitializeComponent();
        }
        double CalculateRatingPoint(Point[] points, float extraPoint)
        {
            if (points.All(p => p.Mark >= 60))
            {
                double result = 0;
                float sumOfCredits = 0;
                foreach(var point in points)
                {
                    if(!point.FinalExamType.Contains("атестація"))
                    {
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

        public PointsForm(string StudentName, MainForm mf, int studentId)
        {
            InitializeComponent();
            this.Text = StudentName + " - бали";
            var thisStudentPoints = mf.studDb.Students.Find(studentId).Points;
            mf.studDb.Points.Load();
            PointsTable.DataSource = thisStudentPoints.ToArray();
            this.pointsTableAdapter2.Fill(this.studentRatingDbDataSet4.Points);
            RatingPoint = CalculateRatingPoint(mf.studDb.Students.Find(studentId).Points.ToArray(), mf.studDb.Students.Find(studentId).ExtraPoint);
            RatingPointBox.Text = RatingPoint.ToString();
        }

        private void PointsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentRatingDbDataSet4.Points". При необходимости она может быть перемещена или удалена.
            this.pointsTableAdapter2.Fill(this.studentRatingDbDataSet4.Points);

        }
    }
}