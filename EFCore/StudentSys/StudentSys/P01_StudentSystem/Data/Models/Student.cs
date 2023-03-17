using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Data.Models
{
    public class Student
    {
        public Student()
        {
            Homeworks = new HashSet<Homework>();
            Courses = new HashSet<StudentsCourses>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public HashSet<Homework> Homeworks { get; set; }

        public HashSet<StudentsCourses> Courses { get; set; }

    }

}
