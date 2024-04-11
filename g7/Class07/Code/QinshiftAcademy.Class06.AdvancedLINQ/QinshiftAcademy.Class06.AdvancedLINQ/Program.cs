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

if(Qinshift.Students.Any(x => !x.IsPartTime))
{
    Console.WriteLine("There is at least one student that is part time");
}

//ALL - checks if all the members in a given collection match a condition
//check if all students are above 18
bool allStudentsAreAbove18 = Qinshift.Students.All(x => x.Age > 18);
if (allStudentsAreAbove18) //if(Qinshift.Students.All(x => x.Age > 18))
{
    Console.WriteLine("All students are above 18");
}


//get the number of students that are part time
int numberOfPartTimeStudents = Qinshift.Students.Count(x => x.IsPartTime);
Console.WriteLine($"The number of part time students is: {numberOfPartTimeStudents}");

//Distinct - eliminates all the duplicates from a collection
List<int> numbers = new List<int> { 3, 5, 3, 4, 4, 8 };
List<int> distinctNumbers = numbers.Distinct().ToList();

//OrderBy - sorts a collection in an ascending order by a given property
//OrderByDescending - sorts a collection in a descending order by a given property
//it doesn't change the original collection!!!!

List<Student> studentsByAgeAsc = Qinshift.Students.OrderBy(x => x.Age).ToList();
//List<Student> studentsByAgeAsc = Qinshift.Students.OrderByDescending(x => x.Age).ToList();
Console.WriteLine("Sorted students:");
studentsByAgeAsc.Print();

//get all the subjects that are followed by students that are part time

//SelectMany flattens all of the projected lists into a result list, instead of returning them as members of a result list
//List<List<Subject>> result = Qinshift.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();
List<Subject> result = Qinshift.Students.Where(x => x.IsPartTime).SelectMany(x => x.Subjects).ToList();
result.Print();