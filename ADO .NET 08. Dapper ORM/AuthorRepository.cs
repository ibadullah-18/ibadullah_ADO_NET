
using Dapper;
using System.Data;

namespace ADO.NET_08.Dapper_ORM;
class AuthorRepository : IAuthorsRepository
{
    private IDbConnection _db;
    public AuthorRepository(IDbConnection db, string connectionString)
    {
        _db = db;
        _db.ConnectionString = connectionString;
    }
    public Author AddAuthor(Author author)
    {
        var sqlQuery = @"INSERT INTO Authosr (FirstName, LastName) VALUES(@FirstName, @LastName)
                         SELECT CAST(SCOPE_IDENTITY() as int)";
        var id = _db.Query<int>(sqlQuery, new
        {
            @FirstName = author.FirstName,
            @LastName = author.LastName
        }).FirstOrDefault();
        author.Id = id;
        return author;
    }

    public void AddAuthors(IEnumerable<Author> authors)
    {
        throw new NotImplementedException();
    }

    public Author GetAuthorById(int id)
    {
      var sqlQuery = @"SELECT * FROM Authosr WHERE Id = @Id";
        return _db.QueryFirstOrDefault<Author>(sqlQuery, new
        {
            @Id = id
        })!;
    }

    public IEnumerable<Author> GetAuthors()
    {
        var sqlQuery = @"SELECT * FROM Authosr";
        return _db.Query<Author>(sqlQuery);
    }

    public void RemoveAuthorById(int id)
    {
        var sqlQuery = @"DELETE Authosr WHERE Id = @Id";
        _db.Execute(sqlQuery, new
        {
            @Id = id
        });
    }

    public void RemoveAuthorsById(int[] ids)
    {
        throw new NotImplementedException();
    }
}

