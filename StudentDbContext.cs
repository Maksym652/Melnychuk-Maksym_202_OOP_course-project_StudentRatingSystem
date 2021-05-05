using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingSystem
{
    class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentDbConnection") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Point> Points { get; set; }
    }
}
