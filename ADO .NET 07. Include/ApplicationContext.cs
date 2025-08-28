

using ADO_.NET_07._Include;
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

        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Explicit;Integrated Security=True;Trust Server Certificate=True;");

    }

}
