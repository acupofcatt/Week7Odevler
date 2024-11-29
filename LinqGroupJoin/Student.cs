namespace LinqGroupJoin;
//Öğrenciler Tablosu (Students)

//StudentId: Öğrencinin benzersiz kimliği

//StudentName: Öğrencinin adı

//ClassId: Öğrencinin ait olduğu sınıfın kimliği
public class Student
{
    public int StudentId { get; set; }
    
    public string StudentName { get; set; }
    
    public int ClassId { get; set; }
}