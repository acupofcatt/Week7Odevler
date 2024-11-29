//Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını
//çalıştırarak konsol ekranına istenilenleri yazdırınız.

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random(); //RASTGELE BİR SAYI OLUŞTURMAK İÇİN

        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            int newNumber = rand.Next(1, 100);

            numbers.Add(newNumber);
        }

//Tek ve Çift Sayılar için

        //ProcessNumbers metoduyla çift sayı kontrolü yapıyoruz, çiftse true döndürüyor
        ProcessNumbers(numbers, n => n % 2 == 0);

        //integer tipinde değer alıp bool değer döndürsün

        static void ProcessNumbers(List<int> numbers, Func<int, bool> filter)
        {
            Console.WriteLine("Çift sayılar:");

            foreach (var number in numbers)
            {
                //true dönüyorsa ekrana çift sayıları yazdırıyor
                if (filter(number))
                {
                    Console.WriteLine(number);
                }
               
            }
            
            Console.WriteLine("Tek sayılar:");

            foreach (var number in numbers)
            {
                //true dönmüyorsa ekrana tek sayıları yazdırıyor
                if (!filter(number))
                {
                    Console.WriteLine(number);
                }
               
            }
        }
        

//Negatif Sayılar

            var negativeNumbers = numbers.Where(num => num < 0).ToList();

            Console.WriteLine("Negatif Sayılar:");

            foreach (var number in negativeNumbers)
            {
                Console.WriteLine(number);
            }

//Pozitif sayılar

            var positiveNumbers = numbers.Where(num => num > 0).ToList();
            
            Console.WriteLine("Pozitif Sayılar:");
            
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }

//15'ten büyük ve 22'den küçük sayılar

            var newNumbers = numbers.Where(num => num > 15 & num < 22).ToList();
            
            Console.WriteLine("15'ten büyük 22'den küçük Sayılar:");

            foreach (var number in newNumbers)
            {
                Console.WriteLine(number);
            }
            
//Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)

            List<int> squares = numbers.Select(n => n * n).ToList();

            Console.WriteLine("Sayıların Karesi:");

            foreach (var square in squares)
            {
                Console.WriteLine(square);
            } 
        
    }
}