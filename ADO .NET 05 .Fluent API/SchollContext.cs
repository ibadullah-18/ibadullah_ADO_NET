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
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchollDbWithFluentAPI;Integrated Security=True;Trust Server Certificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
           .Entity<Group>()
           .Property(x => x.GroupName)
           .IsRequired()
           .HasMaxLength(50);
        modelBuilder
            .Entity<Group>()
            .Property(x => x.GroupRating)
            .IsRequired();
        modelBuilder
            .Entity<Group>()
            .ToTable(x=>x.HasCheckConstraint("CK_GroupRating", "GroupRating >= 0 AND GroupRating <= 12"));
        modelBuilder
            .Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_CourseYear ", "CourseYear >= 1 AND CourseYear <= 4"));
    }

   
}




