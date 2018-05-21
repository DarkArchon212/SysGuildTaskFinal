using Microsoft.EntityFrameworkCore;


//Controller for Context for get and set methods for a student into db
namespace sysguildtask.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {

        }
        
        public DbSet<Student> Students { get; set; }
    }
}