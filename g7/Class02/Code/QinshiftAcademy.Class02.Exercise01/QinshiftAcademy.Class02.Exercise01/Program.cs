using QinshiftAcademy.Class02.Exercise01.Domain.Models;

Student student = new Student("Ana", "Petrovska", "aPetrovska", "test123", new List<int> { 5, 5, 4 });
student.PrintUser();

Console.WriteLine(student.GetAverageGrade());

Teacher teacher = new Teacher("Tanja", "Panchevska", "tPanchevska", "test111", "Advanced C#");

teacher.PrintUser();
teacher.PrintSubject();
