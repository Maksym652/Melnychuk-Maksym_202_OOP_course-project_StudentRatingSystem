using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingSystem
{
    class Point
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public float Credits { get; set; }
        public int Hours { get; set; }
        public string FinalExamType { get; set; }
        public int Mark { get; set; }
        public Student Student { get; set; }
    }
}
