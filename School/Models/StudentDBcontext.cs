using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace School.Models
{
    public class StudentDBcontext : DbContext
    {
        public StudentDBcontext(DbContextOptions <StudentDBcontext> options) : base(options) 
        {
        
        }
        public DbSet<Student> StudentsDate { get; set; }
    }
}
