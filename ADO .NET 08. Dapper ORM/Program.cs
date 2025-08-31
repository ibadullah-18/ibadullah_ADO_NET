// Dapper ORM
using ADO.NET_08.Dapper_ORM;
using Microsoft.Data.SqlClient;

var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Authors;Integrated Security=True;Trust Server Certificate=True;";

IAuthorsRepository repository = new AuthorRepository(new SqlConnection(), connectionString);

#region Add Data
//Author newAuthor = new()
//{
//    FirstName = "John",
//    LastName = "Doe",
//};
//repository.AddAuthor(newAuthor);

#endregion

#region Read Data
//var authors = repository.GetAuthors().ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region Get Author By Id
//var author = repository.GetAuthorById(2);
//Console.WriteLine(author);
#endregion

#region Remove Data by Id
//repository.RemoveAuthorById(3);
#endregion

#region AddAuthors 
//repository.AddAuthors(new List<Author>
//{
//    new Author { FirstName = "Author1", LastName = "LastName1" },
//    new Author { FirstName = "Author2", LastName = "LastName2" },
//    new Author { FirstName = "Author3", LastName = "LastName3" },
//});
#endregion

#region RemoveAuthorsById
repository.RemoveAuthorsById([4, 5, 6, 45]);
#endregion

