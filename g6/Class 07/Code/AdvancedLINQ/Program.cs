using AdvancedLINQ;
using AdvancedLINQ.Domain;
using AdvancedLINQ.Domain.Models;
using System.Net.Cache;

List<Student> studentsOlderThan25 = QinshiftAcademy.Students.Where(x => x.Age > 25).ToList();
studentsOlderThan25.PrintEntities();
Console.WriteLine("==============================");
//studentsOlderThan25.PrintSimple(); //AdvancedLINQ.Domain.Models.Student

List<string> namesOfStudentsOlderThan25 = QinshiftAcademy.Students.Where(x => x.Age > 25).Select(x => x.FirstName).ToList();
namesOfStudentsOlderThan25.PrintSimple();

List<Student> studentsNamedBob = QinshiftAcademy.Students.Where(x => x.FirstName == "Bob").ToList();

var studentsNamedBobSql = from student in QinshiftAcademy.Students //from all students in list QinshiftAcademy.Students
                          where student.FirstName == "Bob" //filter out the ones named Bob
                          select student; //take the whole object (record) student

List<string> fullNames = QinshiftAcademy.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
fullNames.PrintSimple();

List<string> fullNamesSql = (from student in QinshiftAcademy.Students
                             select $"{student.FirstName} {student.LastName}").ToList();

//FIRST/ LAST/ SINGLE /ORDEFAULT 
//First => gets the first element, if no elements it will throw an error
//FirstOrDefault => gets the first element, if no elements will return default and will not throw an error
//Last => gets the last element, if no elements it will throw an error
//LastOrDefault => gets the last element, if no elements will return default and will not throw an error

//Single => gets the only element from the list, if no elements or more than one element - throws an error
//SingleOrDefault => gets the only element from the list, if no elements  default value, if more than one element throws an error

//Student startingWithB = QinshiftAcademy.Students.Single(x => x.FirstName.StartsWith("B")); //ERROR
//Student startingWithB = QinshiftAcademy.Students.SingleOrDefault(x => x.FirstName.StartsWith("B")); //ERROR
Student startingWithT = QinshiftAcademy.Students.SingleOrDefault(x => x.FirstName.StartsWith("T")); //default


List<Student> studentsStartingWithBCheck = QinshiftAcademy.Students.Where(x => x.FirstName.StartsWith("B")).ToList();
if(studentsStartingWithBCheck.Count == 1)
{
    Student s= studentsStartingWithBCheck.FirstOrDefault();
}
else
{
    Console.WriteLine("There is no student or there are more than one student starting with B");
}

//SELECT VS SELECTMANY

//this way we get list of list which is more complicated to workWith
//here we will have a list of subjects of all the students that are part time
//in our case, the result will consist of two list of subjects and the the result itselft will also be a list
var subjectsOfPartTime = QinshiftAcademy.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

//selectMant flattens the list of lists. The members of each list in the list of lists become memebers of the result list
List<Subject> subjectsOfPartTimeStudents = QinshiftAcademy.Students.Where(x => x.IsPartTime)
                                             .SelectMany(x => x.Subjects).ToList();

//Except => gets all except the ones we say that we want to exclude
List<Student> exceptBob = QinshiftAcademy.Students.Except(studentsNamedBob).ToList();
List<Student> exceptPartTime = QinshiftAcademy.Students.Except(QinshiftAcademy.Students.Where(x => x.IsPartTime)).ToList();

exceptBob.PrintEntities();
exceptPartTime.PrintEntities();

//Any / All

bool checkPartTime = QinshiftAcademy.Students.Any(x => x.IsPartTime); //check if at least one item is part time


bool checkAllPartTime = QinshiftAcademy.Students.All(x => x.IsPartTime); //check if all students are part time

//Distinct - remove duplicates
List<int> numbers = new List<int>() {4,6,4,6};
List<int> distinctNumbers = numbers.Distinct().ToList();
Console.WriteLine("=============");
distinctNumbers.PrintSimple();

List<Student> distinctStudentsByAge = QinshiftAcademy.Students.DistinctBy(x => x.Age).ToList();

//OrderBy and OrderByDescending

List<Student> sortedByAge = QinshiftAcademy.Students.OrderBy(x => x.Age).ToList(); //order by is ascending by default
List<Student> sortedByAgeDescending = QinshiftAcademy.Students.OrderByDescending(x => x.Age).ToList();

Console.WriteLine("================");
sortedByAge.PrintEntities();
Console.WriteLine("================");
sortedByAgeDescending.PrintEntities();

List<Student> sortedByname = QinshiftAcademy.Students.OrderBy(x => x.FirstName).ToList();
sortedByname.PrintEntities();

List<Student> sortedByIsPartTime = QinshiftAcademy.Students.OrderBy(x => x.IsPartTime).ToList();
sortedByIsPartTime.PrintEntities();