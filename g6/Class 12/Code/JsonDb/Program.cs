using JsonDb;
using JsonDb.Models;

Database<Student> dbStudents = new Database<Student>();
Database<Subject> dbSubjects = new Database<Subject>();

Subject newSubject = new Subject
{
    Title = "MVC",
    Description = "MVC",
    NumberOfModules = 10,
};

dbSubjects.Insert(newSubject);

Student student = new Student()
{
    FirstName = "Petko",
    LastName = "Petkovski",
    Age = 25,
};

dbStudents.Insert(student);