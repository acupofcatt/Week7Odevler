### **Patikaflix ReadMe**

---

### **Proje Açıklaması**
Bu proje, kullanıcının konsol üzerinden dizi bilgilerini girmesini sağlar. Kullanıcı istediği kadar dizi ekleyebilir ve bu diziler bir listeye kaydedilir. Proje sonunda:
1. Kullanıcıdan alınan diziler arasından yalnızca komedi türünde olanlar filtrelenir.
2. Filtrelenen komedi dizileri, yeni bir sınıfta (`ComedyTvShow`) işlenir ve belirli bir formatta sıralanarak ekrana yazdırılır.

---

### **Projenin İşlevleri**
1. Kullanıcıdan dizi bilgilerini alma.
   - Dizi adı, türü, yapım yılı, bölüm sayısı, yönetmen ve kanal bilgileri alınır.
2. Kullanıcı istediği kadar dizi ekleyebilir.
3. **Komedi Dizilerini Filtreleme:**
   - Kullanıcının eklediği listeden yalnızca `Genre == "Comedy"` olan diziler seçilir.
4. **Listeleme ve Sıralama:**
   - Komedi dizileri yalnızca `Dizi Adı`, `Tür`, `Yönetmen` bilgileriyle listelenir.
   - Dizi adı ve yönetmen adına göre sıralanarak ekrana yazdırılır.

---

### **Veri Modelleri**

#### **`TvShows` Sınıfı**
```csharp
public class TvShows
{
    public string TvShowName { get; set; }
    public int TvShowYear { get; set; }
    public string Genre { get; set; }
    public int Released { get; set; }
    public string Director { get; set; }
    public string Channel { get; set; }
}
```
- **TvShowName:** Dizi adı.
- **TvShowYear:** Yapım yılı.
- **Genre:** Tür (örneğin, Komedi, Drama).
- **Released:** Yayınlanan bölüm sayısı.
- **Director:** Yönetmen adı.
- **Channel:** Yayın kanalı.

#### **`ComedyTvShow` Sınıfı**
```csharp
public class ComedyTvShow
{
    public string TvShowName { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
}
```
- Komedi dizilerini yalnızca gerekli alanlarıyla temsil eder.

---

### **Nasıl Kullanılır?**

1. Program başlatıldığında kullanıcıdan dizi bilgileri istenir.
2. Her dizi girişinden sonra, yeni bir dizi eklemek isteyip istemediği sorulur.
3. Dizi ekleme işlemi bittikten sonra program, komedi türündeki dizileri filtreler ve sıralar.
4. Filtrelenen ve sıralanan diziler ekrana yazdırılır.

---

### **Örnek Kullanım**

#### Girdi:
```
Lütfen bir dizi ekleyiniz:
Lütfen dizi adı giriniz: Friends
Lütfen dizinin yapım yılını giriniz: 1994
Lütfen dizinin türünü giriniz: Comedy
Lütfen dizinin bölüm sayısını giriniz: 236
Lütfen dizinin yönetmenini giriniz: David Crane
Lütfen dizinin yayınlandığı kanalı giriniz: NBC

Yeni bir dizi eklemek için 'Evet', sonlandırmak için 'Hayır' yazınız: Hayır
```

#### Çıktı:
```
Komedi Dizileri:
- Friends | Tür: Comedy | Yönetmen: David Crane
```

