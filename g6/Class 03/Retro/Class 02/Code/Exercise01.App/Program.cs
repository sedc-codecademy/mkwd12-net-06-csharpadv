using Exercise01.Models;

Teacher teacher = new Teacher(1, "Petko", "petkovski_p", "123Test123", "Advanced C#");
teacher.PrintSubjects();
teacher.PrintUser();

Student student = new Student(2, "Stefan", "stefanovski_s", "Test345", new List<int> { 6, 8, 10 });
student.PrintUser();
student.PrintGrades();

List<User> users = new List<User> { teacher, student };