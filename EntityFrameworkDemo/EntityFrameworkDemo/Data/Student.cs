using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
