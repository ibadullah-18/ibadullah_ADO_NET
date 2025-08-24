// Code Many To Many Example

using (BookContext db = new())
{
    List<Book> books = [
        new Book { Name = "C# Programming", Page = 300, Price = 29.99f},
        new Book { Name = "Entity Framework Core",Page = 250, Price = 39.99f },
    ];
    Author author = new()
    {
        FirstName = "John",
        LastName = "Doe"
    };

    Book book = new Book()
    {
        Name = "ASP.NET Core",
        Page = 350,
        Price = 49.99f,
        Authors = [
            new Author { FirstName = "Jane", LastName = "Smith" },
            new Author { FirstName = "Alice", LastName = "Johnson" }
        ]
    };
    db.Authors.Add(author);
    db.Books.Add(book);

    db.SaveChanges();
}