### **Linq ReadMe**

---

### **Proje Açıklaması**
Bu proje, rastgele 10 sayıdan oluşan bir liste üzerinden çeşitli LINQ sorguları yapar. Liste içerisindeki sayılar filtrelenir ve belirtilen kriterlere göre analiz edilerek sonuçlar konsol ekranında gösterilir.

---

### **Program Özellikleri**
1. **Rastgele Sayı Üretimi:**
   - `Random` sınıfı kullanılarak 1 ile 100 arasında rastgele 10 sayı üretilir ve bir listeye eklenir.

2. **LINQ Sorguları:**
   - **Tek ve Çift Sayılar:** Liste, tek ve çift sayılar olarak ayrılır ve konsola yazdırılır.
   - **Negatif Sayılar:** Listede negatif sayılar aranır ve konsola yazdırılır.
   - **Pozitif Sayılar:** Listede pozitif sayılar filtrelenir ve konsola yazdırılır.
   - **15 ile 22 Arasındaki Sayılar:** 15’ten büyük ve 22’den küçük sayılar bulunur.
   - **Sayıların Kareleri:** Listedeki her bir sayının karesi hesaplanarak yeni bir listeye eklenir ve konsola yazdırılır.

---

### **Kullanım Adımları**
1. Programı çalıştırın.
2. Konsola rastgele üretilen 10 sayı ve bu sayılarla ilgili yapılan sorguların sonuçları yazdırılacaktır.

---

### **Örnek Çıktı**
```
Rastgele Sayılar:
23, 45, 16, 9, 2, 67, 32, 50, 19, 8

Çift Sayılar:
16
2
32
50
8

Tek Sayılar:
23
45
9
67
19

Negatif Sayılar:

Pozitif Sayılar:
23
45
16
9
2
67
32
50
19
8

15'ten Büyük 22'den Küçük Sayılar:
16
19

Sayıların Karesi:
529
2025
256
81
4
4489
1024
2500
361
64
```

---

### **Kod Yapısı**
- **`ProcessNumbers` Metodu:**
  - Sayıları tek ve çift olarak filtreler.
- **LINQ Sorguları:**
  - `Where`, `Select` metotları kullanılarak çeşitli kriterlere göre listeyi işler.

---

Bu proje, LINQ sorguları ve rastgele sayı üretimiyle filtreleme, sıralama ve dönüştürme işlemlerine dair örnek bir uygulamadır.
