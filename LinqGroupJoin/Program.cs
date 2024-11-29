
using LinqGroupJoin;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student { StudentId = 12, StudentName = "Volkan Tanır", ClassId = 1 });
        students.Add(new Student { StudentId = 34, StudentName = "Adnen Kaya", ClassId = 2 });
        students.Add(new Student { StudentId = 65, StudentName = "Ayşe Güler", ClassId = 1 });
        students.Add(new Student { StudentId = 19, StudentName = "Hilal Yılmaz", ClassId = 3 });
        students.Add(new Student { StudentId = 25, StudentName = "Hülya Soylu", ClassId = 2 });
        students.Add(new Student { StudentId = 43, StudentName = "Ahmet Yılmaz", ClassId = 2 });

        List<Class> classes = new List<Class>();
        classes.Add(new Class { ClassId = 1, ClassName = "Matematik" });
        classes.Add(new Class { ClassId = 2, ClassName = "İngilizce" });
        classes.Add(new Class { ClassId = 3, ClassName = "Türkçe" });


        var groupedData = classes.GroupJoin(students, classes => classes.ClassId, students => students.ClassId,
            (classes, students) => new
            {
                ClassName = classes.ClassName,
                Students = students.Select(s => s.StudentName)
            }
        );
        
        foreach (var group in groupedData)
        {
            Console.WriteLine($"Sınıf: {group.ClassName}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($" - {student}");
            }
        }
    }
}