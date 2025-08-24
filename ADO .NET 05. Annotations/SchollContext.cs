// Annotations
using Microsoft.EntityFrameworkCore;

class SchollContext : DbContext
{
    public SchollContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Department> Departments { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchollDbWithAnnotations;Integrated Security=True;Trust Server Certificate=True;")
        .UseValidationCheckConstraints();
    }
}



