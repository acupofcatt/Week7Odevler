### **LinqJoin ReadMe**

---

### **Proje Açıklaması**
Bu proje, yazarlar (`Author`) ve kitaplar (`Book`) arasında bir ilişki kurar ve **LINQ Join** kullanılarak her kitabın başlığını ve yazarının adını birleştirir. Proje, veritabanı benzeri bir yapı üzerinden LINQ sorgularıyla veri birleştirme işlemlerine örnek teşkil eder.

---

### **Proje Amaçları**
1. **Veri Modelleri Oluşturma:**
   - Yazarlar ve kitapları temsil eden iki ayrı sınıf (`Author` ve `Book`) oluşturulmuştur.
2. **LINQ Join Kullanımı:**
   - `Author` ve `Book` listeleri, `AuthorId` özelliği üzerinden birleştirilmiştir.
3. **Veri Görselleştirme:**
   - Birleştirilen veriler, her kitabın başlığı ve yazarıyla birlikte konsolda görüntülenmiştir.

---

### **Veri Modelleri**

#### **`Author` Sınıfı**
```csharp
public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
}
```
- **AuthorId:** Yazarın kimlik numarası.
- **Name:** Yazarın adı.

#### **`Book` Sınıfı**
```csharp
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
}
```
- **BookId:** Kitabın kimlik numarası.
- **Title:** Kitabın başlığı.
- **AuthorId:** Kitabın yazarına işaret eden kimlik numarası.

---

### **Nasıl Çalışır?**

1. **Örnek Veri Eklenmesi:**
   - Proje başlatıldığında, üç yazar ve beş kitap örnek veri olarak eklenir.
2. **LINQ Join Sorgusu:**
   - `AuthorId` üzerinden `authors` ve `books` listeleri birleştirilir.
3. **Sonuçların Yazdırılması:**
   - Birleştirilmiş liste, her kitabın başlığı ve yazarıyla konsolda yazdırılır.

---

### **Örnek Kullanım**

#### **Girdi:**
- Yazarlar Listesi:
  ```
  Sabahattin Ali, Orhan Pamuk, Haruki Murakami
  ```
- Kitaplar Listesi:
  ```
  İçimizdeki Şeytan (Sabahattin Ali), Kar (Orhan Pamuk), 1Q84 (Haruki Murakami), Sırça Köşk (Sabahattin Ali), Masumiyet Müzesi (Orhan Pamuk)
  ```

#### **Çıktı:**
```
Kitap Adı: İçimizdeki Şeytan - Yazar: Sabahattin Ali
Kitap Adı: Kar - Yazar: Orhan Pamuk
Kitap Adı: 1Q84 - Yazar: Haruki Murakami
Kitap Adı: Sırça Köşk - Yazar: Sabahattin Ali
Kitap Adı: Masumiyet Müzesi - Yazar: Orhan Pamuk
```

---

### **Kullanım Talimatları**
1. **Projenin Çalıştırılması:**
   - Projeyi çalıştırdığınızda, yazarlar ve kitaplar arasında ilişki kurularak birleştirilmiş sonuçlar ekrana yazdırılır.
2. **Yeni Veri Eklemek:**
   - Yeni yazar veya kitap eklemek için `authors.Add()` ve `books.Add()` metotlarını kullanarak `AuthorId` değerinin eşleştiğinden emin olun.
