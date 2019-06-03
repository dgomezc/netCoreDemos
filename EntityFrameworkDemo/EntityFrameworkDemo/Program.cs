using EntityFrameworkDemo.Repositories;
using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();
            var teacher = repo.GetData();

            foreach (var course in teacher.Courses)
                foreach (var student in course.Students)
                    Console.WriteLine($"The student {student.Name} is in {course.Name} course, imparted by {teacher.Name}");

            Console.ReadLine();
        }
    }
}
