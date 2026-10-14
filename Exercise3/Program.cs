// 📚 3. Bokfilter
// Skapa en klass Book med Title, Author, Year.
// Hämta alla böcker utgivna efter 2010 med .FindAll()
// Sortera alfabetiskt med .OrderBy()
// Kontrollera om det finns en bok av en viss författare med .Any().

List<Book> books = new();

Book books1 = new Book { Title = "Harry Potter", Author = "J.K Rowling", Year = 2015 };
Book books2 = new Book { Title = "Boken", Author = "J.K Rowling", Year = 2011 };
Book books3 = new Book { Title = "Hej Boken", Author = "J.K Rowling", Year = 1998 };

books.Add(books1);
books.Add(books2);
books.Add(books3);

List<Book> booksAfter2010 = books.FindAll(book => book.Year > 2010);

if (booksAfter2010.Count > 0)
{
    Console.WriteLine("Böcker som släpptes efter 2010:");
    foreach (Book book in booksAfter2010)
    {
        Console.WriteLine($"- {book.Title} ({book.Year})");
    }
}

List<Book> sortedBooks = books.OrderBy(book => book.Title).ToList();
Console.WriteLine("Böcker sorterade alfabetiskt:");
foreach (Book book in sortedBooks)
{
    Console.WriteLine($"- {book.Title}");
}

bool hasAuthor = books.Any(book => book.Author == "J.K Rowling");
Console.WriteLine($"Finns det en bok av J.K Rowling? {hasAuthor}");