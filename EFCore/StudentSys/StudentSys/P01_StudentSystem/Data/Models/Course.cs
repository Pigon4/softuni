using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Data.Models
{
    public class Course
    {
        public Course()
        {
            Students = new HashSet<StudentsCourses>();
            Resources = new HashSet<Resources>();
            Homeworks = new HashSet<Homework>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Price { get; set; }
        public HashSet<StudentsCourses> Students { get; set; }
        public HashSet<Resources> Resources { get; set; }
        public HashSet<Homework> Homeworks { get; set; }
    }
}
