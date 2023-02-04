using Microsoft.EntityFrameworkCore;


namespace AG_A1.Models
{
    public class StudentContext : DbContext
    {
        //Getting options from the Program.cs and sending them to the base class
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get;set; }
    }
}
