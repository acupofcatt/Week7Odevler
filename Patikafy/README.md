### **Patikafy ReadMe**

---

#### **Proje Açıklaması**
Bu proje, sanatçılar hakkında bilgi içeren bir liste üzerinde çeşitli sorgular yapar. Sanatçılar, `Singer` sınıfında tanımlanmıştır ve LINQ kullanılarak analiz edilir.

---

#### **Programın İşlevleri**
1. **Adı 'S' ile Başlayan Sanatçıları Listeleme**
2. **Albüm Satışları 10 Milyonun Üzerinde Olan Sanatçıları Listeleme**
3. **2000 Yılı Öncesi Çıkış Yapan Pop Sanatçıları Gruplama ve Sıralama**
4. **En Çok Albüm Satan Sanatçıyı Bulma**
5. **En Yeni ve En Eski Çıkış Yapan Sanatçıyı Bulma**

---

#### **Kullanılan Veri Modeli**
```csharp
public class Singer
{
    public string Name { get; set; }
    public List<string> Genre { get; set; }
    public int Year { get; set; }
    public int Sales { get; set; }
}
```

---

#### **Örnek Çıktılar**
- **Adı 'S' ile Başlayan Sanatçılar:**  
  `Sezen Aksu, Sertab Erener, Serdar Ortaç, Sıla`

- **Albüm Satışları 10 Milyon Üzeri:**  
  `Ajda Pekkan, Serdar Ortaç, Tarkan, Gülben Ergen`

- **En Çok Albüm Satan:**  
  `Tarkan`

- **En Yeni ve En Eski Çıkış:**  
  `En Yeni: Sıla, En Eski: Neşet Ertaş`

---

#### **Kullanım Talimatları**
1. Projeyi çalıştırın ve konsoldaki sonuçları gözlemleyin.
2. Sanatçılar listesine yeni elemanlar eklemek için `singers.Add()` metodunu kullanabilirsiniz.
