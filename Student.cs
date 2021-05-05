using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingSystem
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
        public int Specialty { get; set; }
        public float ExtraPoint { get; set; }
        public float RatingPoint { get; set; }
        public ICollection<Point> Points { get; set; }
        public Student()
        {
            Points = new List<Point>();
        }
    }
}
