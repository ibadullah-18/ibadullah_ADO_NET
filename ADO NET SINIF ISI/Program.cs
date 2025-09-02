// Dapper ORM
using ADO.NET_08.Dapper_ORM;

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
//List<Author> author = new()
//{
//    new Author {FirstName = "Ibadullah", LastName = "Huseynzade" },
//    new Author {FirstName = "Sufiye", LastName = "Huseynzade" },
//    new Author {FirstName = "Mirtalib", LastName = "Huseynzade" },
//};

//repository.AddAuthors(author);
#endregion

#region RemoveAuthorsById
//Author[] author = new[]
//{
//    new Author {Id = 14 },
//    new Author {Id = 15 },
//    new Author {Id = 16 },
//};
//repository.RemoveAuthorsById(author.Select(a => a.Id).ToArray());

#endregion


