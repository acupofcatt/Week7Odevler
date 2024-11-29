using LinqJoin;

public class Program
{
    public static void Main(string[] args)
    {
//  Her iki tabloya da örnek veriler ekleyin. En az 3 yazar ve 4 kitap ekleyin.

        List<Author> authors = new List<Author>();
        authors.Add(new Author { AuthorId = 1, Name = "Sabahattin Ali" });
        authors.Add(new Author { AuthorId = 2, Name = "Orhan Pamuk" });
        authors.Add(new Author { AuthorId = 3, Name = "Haruki Murakami" });


        List<Book> books = new List<Book>();
        books.Add(new Book { BookId = 1, Title = "İçimizdeki Şeytan", AuthorId = 1 });
        books.Add(new Book { BookId = 2, Title = "Kar", AuthorId = 2 });
        books.Add(new Book { BookId = 3, Title = "1Q84", AuthorId = 3 });
        books.Add(new Book { BookId = 4, Title = "Sırça Köşk", AuthorId = 1 });
        books.Add(new Book { BookId = 5, Title = "Masumiyet Müzesi", AuthorId = 2 });

//Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.
        var bookAndAuthors = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                Author = author.Name,
            };
//Oluşturduğunuz LINQ sorgusunun sonucunu ekrana yazdırın. Her kitabın başlığı ve yazarının adını içeren bilgileri göstermelisiniz.

        foreach (var book in bookAndAuthors)
        {
            Console.WriteLine($"Kitap Adı: {book.BookTitle} - Yazar: {book.Author}");
        }
    }
}

