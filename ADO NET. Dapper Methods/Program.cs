using Dapper;
using Microsoft.Data.SqlClient;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;");

#region Sclar Valued Queue - ExcuteScalar
//var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Students");
//Console.WriteLine(result);

#endregion

#region Query Single
//var book = db.QueryFirstOrDefault<Book>("SELECT * FROM Books WHERE Name LIKE @Name", new { @Name = "%Visual%" });
//if (book is not null)
//    Console.WriteLine(book);
//else Console.WriteLine("Book not found");
#endregion

#region Query
//var books = db.Query<Book>("SELECT * FROM Books").ToList();
//books.ForEach(Console.WriteLine);

#endregion

#region Query Multiple = Read, ReadFirst, ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault
//var sqlQuery = @"
//SELECT * FROM Authors WHERE FirstName = @FirstName
//SELECT * FROM Books   WHERE Id > @Id;";

//var result = db.QueryMultiple(sqlQuery, new { @FirstName = "Mark", @Id = 5 });

//var authors = result.Read<Author>().ToList();
//var books = result.Read<Book>().ToList();

//authors.ForEach(Console.WriteLine);
//Console.WriteLine();
//books.ForEach(Console.WriteLine);
#endregion

#region Query Specific Colums
//var sqlQuery = "SELECT Id, FirstName FROM Authors"; 

//var authors = db.Query<Author>(sqlQuery).ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region One To Many
//var sql = @"SELECT * FROM Students AS S 
//JOIN Groups AS G ON G.Id = S.Id_Group";

//var student = db.Query<Student, Group, Student>(sql, 
//    (s, g) =>
//{
//    s.Group =g;
//    return s;
//}).ToList();
//student.ForEach(Console.WriteLine);
#endregion

#region Many To Many


#endregion