
// 🎓 1. Studentbetyg-Analys
// Skapa en klass Student med egenskaperna Name, Grade och Passed (bool).
//  ✅ Gör en lista av studenter och använd:
// .FindAll() för att hitta de som klarade kursen
// .Average() för att räkna ut medelbetyg
// .Sort() för att sortera efter betyg
//  💡 Extra: Visa de 3 bästa studenterna med .Take(3).

List<Student> students = new();

Student student1 = new Student { Name = "Erik", Grade = "B", Passed = true };
Student student2 = new Student { Name = "Julia", Grade = "F", Passed = false };
Student student3 = new Student { Name = "Anders", Grade = "C", Passed = true };
Student student4 = new Student { Name = "Per", Grade = "E", Passed = true };
Student student5 = new Student { Name = "Berit", Grade = "D", Passed = true };
Student student6 = new Student { Name = "Gunilla", Grade = "A", Passed = true };
Student student7 = new Student { Name = "Adrian", Grade = "D", Passed = true };

students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);
students.Add(student5);
students.Add(student6);
students.Add(student7);

List<Student> passedStudents = students.FindAll(student => student.Passed);
passedStudents.Sort((a, b) => b.Grade.CompareTo(a.Grade));

double averageGrade = passedStudents.Average(student => student.Grade switch
{
    "A" => 5,
    "B" => 4,
    "C" => 3,
    "D" => 2,
    "E" => 1,
    "F" => 0
});

Console.WriteLine("Studenter som klarade kursen:");
foreach (Student student in passedStudents)
{
    Console.WriteLine($"- {student.Name}: {student.Grade}");
}

Console.WriteLine($"Medelbetyg för de som klarade: {averageGrade}");

Console.WriteLine("\nTop 3 studenter:");
foreach (Student student in passedStudents.Take(3))
{
    Console.WriteLine($"- {student.Name}: {student.Grade}");
}
