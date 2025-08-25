using System.Data.Entity;

namespace FinalAssignment
{
    // The connection string name "SchoolContext" in App.config must match this class name
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
