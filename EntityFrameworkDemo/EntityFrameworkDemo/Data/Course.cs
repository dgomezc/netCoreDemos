using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Data
{
    public class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
