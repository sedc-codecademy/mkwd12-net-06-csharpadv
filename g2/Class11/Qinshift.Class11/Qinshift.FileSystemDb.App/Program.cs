using Qinshift.FileSystemDb.App;
using Qinshift.FileSystemDb.Domain.Enums;
using Qinshift.FileSystemDb.Domain.Models;

Db<Student> studentDb = new Db<Student>();
Db<Subject> subjectDb = new Db<Subject>();

// Method that insert some initial data in the database
void Seed()
{
    // Check if inserting works
    // If the databases are empty, only then this will insert the initial data
    if (studentDb.GetAll().Count == 0)
    {
        studentDb.Insert(new Student("Bob", "Bobsky", 24));
        studentDb.Insert(new Student("Jill", "Jillsky", 14));
        studentDb.Insert(new Student("Smith", "Smithsky", 34));
    }

    if(subjectDb.GetAll().Count == 0)
    {
        subjectDb.Insert(new Subject("C# Basic", 10, Academy.Code));
        subjectDb.Insert(new Subject("C# Advanced", 25,Academy.Code));
        subjectDb.Insert(new Subject("Networks", 5,Academy.Networks));
    }
}

Seed();

Console.WriteLine("===== TESTING =====");
// Check if GetAll work

List<Student> students = studentDb.GetAll();
List<Subject> subjects = subjectDb.GetAll();
Console.WriteLine("=== GET ALL =====");


foreach(Student student in students)
{
    Console.WriteLine(student.Info());
}

foreach (Subject subject in subjects)
{
    Console.WriteLine(subject.Info());
}

Console.ReadLine();

Console.WriteLine("======= GET BY ID =======");
// Check if GetById works
Console.WriteLine(studentDb.GetById(2).Info());
Console.WriteLine(subjectDb.GetById(1).Info());
Console.ReadLine();

// Insert student by inputs
Console.WriteLine("======= INSERT NEW USER =======");
Console.WriteLine("Enter First Name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter Last Name: ");
string lastName = Console.ReadLine();
Console.WriteLine("Enter Age: ");
int age = int.Parse(Console.ReadLine());
Student newStudent = new Student(firstName, lastName, age);
studentDb.Insert(newStudent);
Console.WriteLine("======= STUDENT CREATED =======");
Console.WriteLine("======= GET ALL AGAIN =======");
foreach (Student student in studentDb.GetAll())
{
    Console.WriteLine(student.Info());
}
Console.ReadLine();