using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo.Data
{
    class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
            
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, Name = "Teacher 1" },
                new Teacher { TeacherId = 2, Name = "Teacher 2" }
            );
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Name = "First", City = "Madrid", TeacherId = 1 },
                new Course { CourseId = 2, Name = "Second", City = "Madrid", TeacherId = 2 },
                new Course { CourseId = 3, Name = "Third", City = "Madrid", TeacherId = 1 }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Student 1", CourseId = 1 },
                new Student { StudentId = 2, Name = "Student 2", CourseId = 1 },
                new Student { StudentId = 3, Name = "Student 3", CourseId = 2 },
                new Student { StudentId = 4, Name = "Student 4", CourseId = 2 },
                new Student { StudentId = 5, Name = "Student 5", CourseId = 3 },
                new Student { StudentId = 6, Name = "Student 6", CourseId = 3 },
                new Student { StudentId = 7, Name = "Student 7", CourseId = 3 }
            );
        }
    }
}

