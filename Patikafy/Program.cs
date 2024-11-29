//Yukarıda 11 sanatçımız için bir veri tablosu verilmiştir. Tablodaki her bir satır bir nesneye karşılık gelecek şekilde
// bu nesnelerden oluşan bir liste tanımlayınız. Ardından bu liste üzerinden aşığıdaki sorguları gerçekleştiriniz.

using Patikafy;

public class Program
{
    public static void Main(string[] args)
    {
        List<Singer> singers = new List<Singer>();

        singers.Add(new Singer
            { Name = "Ajda Pekkan", Genre = new List<string> { "Pop" }, Year = 1968, Sales = 20000000 });
        singers.Add(new Singer
        {
            Name = "Sezen Aksu", Genre = new List<string>
            {
                "Pop", "Türk Halk Müziği"
            },
            Year = 1972, Sales = 10000000
        });
        singers.Add(
            new Singer { Name = "Funda Arar", Genre = new List<string> { "Pop" }, Year = 1999, Sales = 3000000 });
        singers.Add(new Singer
            { Name = "Sertab Erener", Genre = new List<string> { "Pop" }, Year = 1994, Sales = 5000000 });
        singers.Add(new Singer { Name = "Sıla", Genre = new List<string> { "Pop" }, Year = 2009, Sales = 3000000 });
        singers.Add(new Singer
            { Name = "Serdar Ortaç", Genre = new List<string> { "Pop" }, Year = 1994, Sales = 10000000 });
        singers.Add(new Singer { Name = "Tarkan", Genre = new List<string> { "Pop" }, Year = 1992, Sales = 40000000 });
        singers.Add(new Singer
            { Name = "Hande Yener", Genre = new List<string> { "Pop" }, Year = 1999, Sales = 7000000 });
        singers.Add(new Singer { Name = "Hadise", Genre = new List<string> { "Pop" }, Year = 2005, Sales = 5000000 });
        singers.Add(new Singer
        {
            Name = "Gülben Ergen", Genre = new List<string>
            {
                "Pop", "Türk Halk Müziği"
            },
            Year = 1997, Sales = 10000000
        });
        singers.Add(new Singer
        {
            Name = "Neşet Ertaş", Genre = new List<string>
            {
                "Türk Sanat Müziği", "Türk Halk Müziği"
            },
            Year = 1960, Sales = 2000000
        });

//Adı 'S' ile başlayan şarkıcılar
        var nameStartsWithS = singers.Where(singer => singer.Name.StartsWith("S"));

        Console.WriteLine("Adı S ile başlayan Şarkıcılar:");
        foreach (var singer in nameStartsWithS)
        {
            Console.WriteLine(singer.Name);
        }

//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar

        var moreTenMillion = singers.Where(singer => singer.Sales > 10000000);

        Console.WriteLine("Albüm satışları 10Milyon Üzerinde Olan Şarkıcılar:");


        foreach (var singer in moreTenMillion)
        {
            Console.WriteLine(singer.Name);
        }

//2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

        var popSingers = singers.Where(singer => singer.Year < 2000 && singer.Genre.Contains("Pop")).GroupBy(singer => singer.Year).OrderBy(singer => singer.Name);

        Console.WriteLine("2000 öncesi çıkış yapmış Pop Şarkıcıları:");

        foreach (var singer in popSingers)
        {
            Console.WriteLine(singer.Name);
        }

//En çok albüm satan şarkıcı

        Console.WriteLine("En çok albüm satan Şarkıcı:");

        var sortedSaleDescending = singers.OrderByDescending(singer => singer.Sales).First();

        Console.WriteLine(sortedSaleDescending.Name);


//En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı

        Console.WriteLine("En yeni çıkış yapmış Şarkıcı:");

        var latestSinger = singers.OrderByDescending(singer => singer.Year).First();

        Console.WriteLine(latestSinger.Name);

        Console.WriteLine("En eski çıkış yapan Şarkıcı:");

        var earliestSinger = singers.OrderBy(singer => singer.Year).First();

        Console.WriteLine(earliestSinger.Name);
    }
}