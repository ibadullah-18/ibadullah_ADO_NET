// Annotations
using SchollContext db = new();

Student student = new()
{
    FirstName = "John",
    LastName = "Doe"
};

db.Students.Add(student);

Group group = new()
{
    GroupName = "FSDA_Oct_24_5_az",
    GroupRating = 5,
    CourseYear = 2024,
    Students = [student]
};

db.Groups.Add(group);

Student student1 = new()
{
    FirstName = "Ibadullah",
    LastName = "Huseynzade",
    GroupId = 1
};

db.Students.Add(student1);


Faculty faculty = new()
{
    FacultyName = "BackEnd Programming"
};

db.Faculties.Add(faculty);

db.Departments.Add(
    new Department
    {
        DepartmentName = "Development",
        Teachers = [
            new Teacher
            {
                FirstName = "Ali",
                LastName = "Aliyev",
                Email = "aliAliyev12@gmail.com",
                Salary = 1500,
                Bonus = 200,
            },
            new Teacher
            {
                FirstName = "Memmed",
                LastName = "Memmedzade",
                Email = "Memmedeli23@gmail.com",
                Salary = 56302,
                Bonus = 5000,
            }
            ]
    }
    );

db.SaveChanges();