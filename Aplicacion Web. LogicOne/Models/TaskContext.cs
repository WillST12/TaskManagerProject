using Microsoft.EntityFrameworkCore;

namespace Aplicacion_Web._LogicOne.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<TaskManagerDB> Tasks_Table { get; set; }

        public TaskContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
