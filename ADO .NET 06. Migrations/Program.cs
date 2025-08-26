// Migrations 
using var db = new StudentContext();
List<Student> students1 = new()
{
    new Student { FirstName = "John", LastName = "Doe", Age = 20 },
    new Student { FirstName = "Jane", LastName = "Smith", Age = 22 }
};

db.Students.AddRange(students1);

db.SaveChanges();