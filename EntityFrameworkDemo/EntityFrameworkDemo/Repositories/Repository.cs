using EntityFrameworkDemo.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkDemo.Repositories
{
    public class Repository
    {
        public Teacher GetData()
        {
            using (SchoolDbContext context = new SchoolDbContext())
            {
                var teacher = context.Teachers
                                      .Include(x => x.Courses)
                                      .ThenInclude(x => x.Students)
                                      .First();
                return teacher;
            }
        }
    }
}
