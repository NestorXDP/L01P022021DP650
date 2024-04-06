using Microsoft.EntityFrameworkCore;



namespace L01P022021DP650.Models
{
    public class notasDbContext : DbContext
    {
        public notasDbContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<facultad> facultad { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<alumnos> alumnos { get; set; }
    }
}
