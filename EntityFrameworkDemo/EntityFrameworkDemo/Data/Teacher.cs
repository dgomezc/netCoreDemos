using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Data
{
    public class Teacher
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int TeacherId { get; set; }

        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
