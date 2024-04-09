//Get all the students older than 25
using QinshiftAcademy.Class06.AdvancedLINQ;
using QinshiftAcademy.Class06.AdvancedLINQ.Models;

//We use WHERE to filter members of a given collection by a given condition

List<Student> studentsOlderThan25 = Qinshift.Students.Where(x => x.Age > 25).ToList();
studentsOlderThan25.Print();

//get all students named Bob
List<Student> studentsNamedBob = Qinshift.Students.Where(x => x.FirstName == "Bob").ToList();
studentsNamedBob.Print();

//get full names for all of the students, means we want to have a collection of the full names at the end
List<string> fullNames = Qinshift.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
foreach(string fullName in fullNames)
{
    Console.WriteLine(fullName);
}


//get the fullNames of all students that are part time

List<string> partTimeStudents =
    Qinshift.Students.Where(x => x.IsPartTime).Select(x => $"{x.FirstName} {x.LastName}").ToList();

//FIRST/FIRSTORDEFAULT/LAST/LASTORDEFAULT/SINGLE/SINGLEORDEFAULT
//First -> Gets the first element that fullfills a condition
//Last -> Gets the last element that fulfills a condition
//Single -> returns the element that fulfills a condition, but if there are multiple members in the collection
//that follow the condition, it will throw an error
//When we use any appropriate method with OrDefault if it doesn't find any member that fulfills a condition it
//returns the default value for the given type

//Student fullTimeStudent = Qinshift.Students.SingleOrDefault(x => !x.IsPartTime); - ERROR, there are multiple students that are not part time

//check if there is a student under 18
Student studentUnder18 = Qinshift.Students.FirstOrDefault(x => x.Age < 18);
if(studentUnder18 == null)
{
    Console.WriteLine("All of the students are older than 18");
}

//ANY 
//check if there are full time students
List<Student> fullTimeStudents = Qinshift.Students.Where(x => !x.IsPartTime).ToList();
if(fullTimeStudents.Count > 0)
{
    Console.WriteLine("There are full time students");
}

bool areThereFullTimeStudents = Qinshift.Students.Any(x => !x.IsPartTime);