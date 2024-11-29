// Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor.
// Elemanların oluşturuluşu Console ekranı üzerinden olacak.

using Patikaflix;

public class Program
{
    public static void Main(string[] args)
    {
        //programa devam edip etmeme isteğini tanımlıyorum
        bool devam = false;
        List<TvShows> shows = new List<TvShows>();
        do
        {
            //kullanıcıdan yeni bir dizi bilgisi alıyorum
            Console.WriteLine("Dizi ekleyiniz:");

            //dizi nesnesi oluşturan GetShows metodunu çağırıorum
            shows.Add(GetShows());
            
// Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.

            //kullanıcı devam etmek istiyor mu?
            Console.WriteLine("Yeni bir dizi eklemek için 'Evet' sonlandırmak için 'Hayır' giriniz.");
            string input = Console.ReadLine().ToLower();
            //eğer evet girerse döngü devam etsin ve yeni film eklemeye devam etsin
            if (input == "evet")
            {
                devam = true;
            }
            //evet harici bir girişte hayır kabul ederek döngüyü sonlandırıyorum
            else
            {
                devam = false;
            }
        } while (devam == true);

// İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen
// bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)

        var comedyShows = shows.Where(show => show.Genre == "Komedi")
            .Select(show => new InputList
            { TvShowName = show.TvShowName, Genre = "Komedi", Director = show.Director })
            .OrderBy(show => show.TvShowName)
            .ThenBy(show => show.Director)
            .ToList();
        
//  Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da
// yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.
        
        Console.WriteLine("Komedi Dizileri:");
        
        foreach (var comedy in comedyShows)
        {
            Console.WriteLine($"Dizi Adı: {comedy.TvShowName}, Tür: {comedy.Genre}, Yönetmen: {comedy.Director}");
        }

    }

    public static TvShows GetShows()
    {
        //yeni bir nesne oluşturuyorum
        TvShows tvShows = new TvShows();

        Console.WriteLine("Lütfen dizi adı giriniz:");

        //Kullanıcının girdiği ismi ilk harfi büyük diğerleri küçük olacak şekilde düzenledim
        string nameIlk = Console.ReadLine().ToLower();
        string name = char.ToUpper(nameIlk[0]).ToString();

        //kullanıcıdan aldığım ismi dizinin ismine atadım
        tvShows.TvShowName = name;

        Console.WriteLine("Lütfen dizinin yapım yılını giriniz:");
        string yearStr = Console.ReadLine();

        // Int'e dönüştürmeye çalış
        if (int.TryParse(yearStr, out int year))
        {
            //kullanıcıdan aldığım sayıyı filmin puanına atadım
            tvShows.TvShowYear = year;
        }
        else
        {
            //hata verdi
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            tvShows.TvShowYear = 0;
        }

        Console.WriteLine("Lütfen dizinin türünü giriniz:");


        string genreIlk = Console.ReadLine().ToLower();
        string genre = char.ToUpper(genreIlk[0]).ToString();

        tvShows.Genre = genre;

        Console.WriteLine("Lütfen dizinin yapım yılını giriniz:");
        string? releasedStr = Console.ReadLine();

        // Int'e dönüştürmeye çalış
        if (int.TryParse(releasedStr, out int released))
        {
            //kullanıcıdan aldığım sayıyı filmin puanına atadım
            tvShows.Released = released;
        }
        else
        {
            //hata verdi
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            tvShows.Released = 0;
        }

        Console.WriteLine("Lütfen dizinin yönetmenini giriniz:");


        string directorIlk = Console.ReadLine().ToLower();
        string director = char.ToUpper(directorIlk[0]).ToString();

        tvShows.Director = director;

        Console.WriteLine("Lütfen dizinin yayınlandığı kanal adını giriniz:");


        string channelIlk = Console.ReadLine().ToLower();
        string channel = char.ToUpper(channelIlk[0]).ToString();

        tvShows.Channel = channel;


        return tvShows;
    }
}


