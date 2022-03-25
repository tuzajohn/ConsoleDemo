using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Entities
{
    public class DemoContext:DbContext
    {
        public DemoContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=demo;Integrated Security=true;");
        }

        public DbSet<CourseUnit> CourseUnits { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseUnit> StudentCourseUnits { get; set; }
    }
}
