using Microsoft.EntityFrameworkCore;

namespace Aplicacion_Web._LogicOne.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<TaskManagerDB> Tasks_Table { get; set; }

        public TaskContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaskManagerDB>()
                .Property(t => t.EstadoTarea)
                .HasConversion<string>();

        }
    }
}
