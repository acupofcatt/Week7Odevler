### **LinqGroupJoin ReadMe**

---

### **Proje Açıklaması**

Bu proje, **öğrenciler** (`Student`) ve **sınıflar** (`Class`) arasında bir ilişki kurar. **LINQ GroupJoin** kullanılarak, her sınıfa ait öğrenciler gruplanır ve konsol ekranında sınıf isimleri ve öğrencileri listelenir.

---

### **Veri Modelleri**

#### **`Student` Sınıfı**
```csharp
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }
}
```
- **StudentId:** Öğrencinin kimlik numarası.
- **StudentName:** Öğrencinin adı.
- **ClassId:** Öğrencinin kayıtlı olduğu sınıfın kimlik numarası.

#### **`Class` Sınıfı**
```csharp
public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}
```
- **ClassId:** Sınıfın kimlik numarası.
- **ClassName:** Sınıfın adı.

---

### **Nasıl Çalışır?**

1. **Öğrenci ve Sınıf Listelerinin Tanımlanması:**
   - `students` listesi, her bir öğrenci ile hangi sınıfa ait olduğunu belirler.
   - `classes` listesi, mevcut sınıfların isim ve kimlik bilgilerini içerir.

2. **GroupJoin Kullanımı:**
   - `GroupJoin`, `students` ve `classes` listelerini `ClassId` özelliği üzerinden birleştirir.
   - Her sınıfa ait öğrenciler gruplanır ve sonuç yeni bir koleksiyon oluşturur.

3. **Sonuçların Konsola Yazdırılması:**
   - Her sınıfın adı yazdırılır.
   - Sınıfa ait öğrenciler alt alta listelenir.

---

### **Örnek Çıktı**

#### **Girdi:**
- Öğrenciler Listesi:
  ```
  Volkan Tanır (Matematik), Adnen Kaya (İngilizce), Ayşe Güler (Matematik),
  Hilal Yılmaz (Türkçe), Hülya Soylu (İngilizce), Ahmet Yılmaz (İngilizce)
  ```

- Sınıflar Listesi:
  ```
  Matematik, İngilizce, Türkçe
  ```

#### **Çıktı:**
```
Sınıf: Matematik
 - Volkan Tanır
 - Ayşe Güler
Sınıf: İngilizce
 - Adnen Kaya
 - Hülya Soylu
 - Ahmet Yılmaz
Sınıf: Türkçe
 - Hilal Yılmaz
```

---

### **Kodun İşleyişi**
- **GroupJoin:**  
  Sınıflar (`classes`) ve öğrenciler (`students`), `ClassId` üzerinden ilişkilendirilir:
  ```csharp
  classes.GroupJoin(
      students,
      classes => classes.ClassId,
      students => students.ClassId,
      (classes, students) => new { ClassName = classes.ClassName, Students = students.Select(s => s.StudentName) }
  );
  ```
- **Yazdırma:**  
  Gruplar dolaşılır, her sınıf ve o sınıfa ait öğrenciler konsola yazdırılır:
  ```csharp
  foreach (var group in groupedData)
  {
      Console.WriteLine($"Sınıf: {group.ClassName}");
      foreach (var student in group.Students)
      {
          Console.WriteLine($" - {student}");
      }
  }
  ```

---

Bu proje, LINQ GroupJoin kullanarak bir ana tablo ile ilişkili detayları gruplamayı ve yazdırmayı gösterir.
