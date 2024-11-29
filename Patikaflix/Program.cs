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
            //kullanıcıdan yeni bir film bilgisi alıyorum
            Console.WriteLine("Lütfen bir dizi ekleyiniz:");
            
            //film nesnesi oluşturan GetMovie metodunu çağırıorum
            shows.Add(GetShows());
        
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
    }

    public TvShows GetShows()
    {
        //yeni bir nesne oluşturuyorum
        TvShows tvShows = new TvShows();

        Console.WriteLine("Lütfen dizi adı giriniz:");

        //Kullanıcının girdiği ismi ilk harfi büyük diğerleri küçük olacak şekilde düzenledim
        string nameIlk = Console.ReadLine().ToLower();
        string name = char.ToUpper(nameIlk[0]).ToString();

        //kullanıcıdan aldığım ismi dizinin ismine atadım
        TvShows.TvShowName = name;

        Console.WriteLine("Lütfen dizinin yapım yılını giriniz:");
        string yearStr = Console.ReadLine();

        // Int'e dönüştürmeye çalış
        if (int.TryParse(yearStr, out int year))
        {
            //kullanıcıdan aldığım sayıyı filmin puanına atadım
            TvShows.TvShowYear = year;
        }
        else
        {
            //hata verdi
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            TvShows.TvShowYear = 0;
        }
        
        Console.WriteLine("Lütfen dizinin türünü giriniz:");


        string genreIlk = Console.ReadLine().ToLower();
        string genre = char.ToUpper(genreIlk[0]).ToString();

        TvShows.Genre = genre;
        
        Console.WriteLine("Lütfen dizinin yapım yılını giriniz:");
        string releasedStr = Console.ReadLine();

        // Int'e dönüştürmeye çalış
        if (int.TryParse(releasedStr, out int released))
        {
            //kullanıcıdan aldığım sayıyı filmin puanına atadım
            TvShows.Released = released;
        }
        else
        {
            //hata verdi
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz! 0 kabul edildi.");
            TvShows.Released = 0;
        }
        
        Console.WriteLine("Lütfen dizinin yönetmenini giriniz:");


        string directorIlk = Console.ReadLine().ToLower();
        string director = char.ToUpper(directorIlk[0]).ToString();

        TvShows.Director = director;
        
        Console.WriteLine("Lütfen dizinin yayınlandığı kanal adını giriniz:");


        string channelIlk = Console.ReadLine().ToLower();
        string channel = char.ToUpper(channelIlk[0]).ToString();

        TvShows.Channel = channel;


        return tvShows;
    }
}
// 
// Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.

//Ardından aşağıda istenilen işlemleri gerçekleştiriniz.
// 
// İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
// 
//  Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.