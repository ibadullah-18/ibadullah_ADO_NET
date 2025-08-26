// Migrations 
using Microsoft.EntityFrameworkCore;

class StudentContext : DbContext
{
    public StudentContext()
    {

    }
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Migrations;Integrated Security=True;Trust Server Certificate=True;");
    }
}