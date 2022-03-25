using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string OtherNames { get; set; }

        public DateTime DoB { get; set; }
    }
}
