

using Microsoft.EntityFrameworkCore;

class ApplicationContext : DbContext

{

    public ApplicationContext()

    {

    }

    public DbSet<Student> Students { get; set; }

    public DbSet<Group> Groups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Eager;Integrated Security=True;Trust Server Certificate=True;");

    }

}
