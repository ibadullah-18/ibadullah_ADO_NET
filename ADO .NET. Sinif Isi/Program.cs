using ADO_.NET._Sinif_Isi;
using Microsoft.EntityFrameworkCore;
// show themas for eager loading
using LibraryContext db = new();



while (true)
{
    Console.Clear();
    Console.WriteLine("1. Themas");
    Console.WriteLine("2. Categories");
    Console.WriteLine("3. Authors");
    Console.WriteLine("0. Exit");

    string i = Console.ReadLine();
    Console.Clear();
    if (i == "1")
    {

        var themas = db.Themes.
        Include(s => s.Books)
        .ToList();

        Console.WriteLine("Themas");
        foreach (var thema in themas)
        {
            Console.WriteLine($"{thema.Name}:");
            foreach (var book in thema.Books)
            {
                Console.WriteLine($" - {book.Name}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Davam etmek ucun enter bas");
        Console.ReadLine();
    }
    else if (i == "2")
    {
        var categories = db.Categories
        .Include(s => s.Books)
        .ToList();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Name}:");
            foreach (var book in category.Books)
            {
                Console.WriteLine($" - {book.Name} ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
    else if (i == "3")
    {
        var authors = db.Authors
        .Include(s => s.Books)
        .ToList();

        foreach (var author in authors)
        {
            Console.WriteLine($"{author.FirstName} {author.LastName}:");
            foreach (var book in author.Books)
            {
                Console.WriteLine($" - {book.Name} ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
    else if (i == "0")
        break;
}

// show thems for explicit loading

//var themas2 = db.Themes.FirstOrDefault(s=> s.Id == 1);

//if(themas2 != null)
//{
//    db.Entry(themas2).Collection(s => s.Books).Load();
//    Console.WriteLine($"{themas2.Name}:");
//    foreach (var book in themas2.Books)
//    {
//        Console.WriteLine($" - {book.Name}");
//    }
//}