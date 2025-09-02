using Dapper;
using Microsoft.Data.SqlClient;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=True;Trust Server Certificate=True;");

#region Many To Many

var aql = @"SELECT *
FROM Authors AS A
JOIN AuthorBook AS AB
ON A.Id = AB.AuthorId
JOIN Books AS B
ON B.Id = AB.BooksId
";

var authors = db.Query<Author, Book, Author>(aql,
    (a, b) =>
    {
        a.Books.Add(b);
        return a;
    }
    );

foreach (var item in authors)
{
    Console.WriteLine(authors);
}

#endregion