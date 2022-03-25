using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Entities
{
    public class StudentCourseUnit : BaseEntity
    {
        public int StudentId { get; set; }
        public int CourseUnitId { get; set; }

        public virtual Student Student { get; set; }
        public virtual CourseUnit CourseUnit { get; set; }
    }
}
