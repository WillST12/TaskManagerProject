using Microsoft.EntityFrameworkCore;

namespace Aplicacion_Web._LogicOne.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<TaskManagerDB> Tasks_DB { get; set; }

        public TaskContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
