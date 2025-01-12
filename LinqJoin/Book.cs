namespace LinqJoin;
//   Kitaplar Tablosu (Books)
// 
// BookId (int) - Kitabın benzersiz kimliği
// 
// Title (string) - Kitabın başlığı
// 
// AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)
public class Book
{
    public int BookId { get; set; }
    
    public string Title { get; set; }
    
    public int AuthorId { get; set; }
}