
using LinqMethods.Entities;
using LinqMethods.Helpers;

ConsoleHelper.PrintInColor("\n====================== LINQ ======================\n", ConsoleColor.DarkCyan);



ConsoleHelper.PrintInColor("\n=================== Where ===================\n", ConsoleColor.Red);
// Where filters items by an expression that must be true or false
// Where always returns IEnumerable of the same type as the target collection
// Returns the number of elements that met the condition

// LINQ with lambda
IEnumerable<Student> findBobsLambda = SEDC.Students.Where(s => s.FirstName == "Bob");

findBobsLambda.ToList().PrintEntities();

// SQL-like LINQ
IEnumerable<Student> findBobsSqlSyntax = from student in SEDC.Students
                                         where student.FirstName == "Bob"
                                         select student;
findBobsSqlSyntax.ToList().PrintEntities();



ConsoleHelper.PrintInColor("\n=================== Select ===================\n", ConsoleColor.Yellow);
// Select creates a collection with a different form of the initial collection by an expression that can be any value
// Select returns IEnumerable with the type of the value in the expression
// Returns the same number of elements as the initial collection

List<string> studentFirstNames = SEDC.Students.Select(s => s.FirstName).ToList();
studentFirstNames.PrintSimple();
Console.WriteLine(SEDC.Students.Count);
Console.WriteLine(studentFirstNames.Count);

List<string> studentFullNames = SEDC.Students.Select(s => $"{s.FirstName} {s.LastName}").ToList();
studentFullNames.PrintSimple();

// Complex Example: Get students which are part-time and have subjects from the programming academy

// Lambda complex example
List<Student> programmingStudentsLambda = SEDC.Students
                        .Where(x => x.IsPartTime && x.Subjects
                            .Where(s => s.Type == Academy.Programming)
                            .ToList().Count != 0)
                        .ToList();
programmingStudentsLambda.PrintEntities();

// SQL Like complex example
List<Student> programmingStudentsSqlLike = (from s in SEDC.Students
                                            where s.IsPartTime &&
                                                (from x in s.Subjects
                                                 where x.Type == Academy.Programming
                                                 select x).ToList().Count != 0
                                            select s).ToList();




ConsoleHelper.PrintInColor("\n=================== First/Single/Last (OrDefault) ===================\n", ConsoleColor.Green);
// First => Gets first element, if no elements it will throw error
// FirstOrDefault => Gets first element, if no elements will return default and will not throw error
// Last => Gets last element, if no elements it will throw error
// LastOrDefault => Gets last element, if no elements will return default and will not throw error
// Single => Gets the only element from list, if more than one elements or no elements will throw error
// SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error


//Console.WriteLine(SEDC.Students.Single(s => s.Age > 30)); // Exception!
Student jill = SEDC.Students.SingleOrDefault(s => s.FirstName == "Jill");
Console.WriteLine(jill.GetInfo());



ConsoleHelper.PrintInColor("\n================== Select Many ==================\n", ConsoleColor.Red);
// It flatens list of lists
// Flattening => When we make one list out of multiple lists of the same type

// Example: subjects of all part-time students

// Select
// Issue because it does not give all the results in one list, but creates a list of lists
List<List<Subject>> partTimeStudentsSubjects = SEDC.Students.Where(s => s.IsPartTime).Select(s => s.Subjects).ToList();

// SelectMany
// Flatens all the lists in to one list
List<Subject> partTimeStudentsSubjectsSelectMany = SEDC.Students.Where(s => s.IsPartTime).SelectMany(s => s.Subjects).ToList();
partTimeStudentsSubjectsSelectMany.PrintEntities();



ConsoleHelper.PrintInColor("\n================== Distinct/DistinctBy ==================\n", ConsoleColor.Yellow);
// Removes all duplicate values from a collection
// Returns IEnumerable of the same type as the original collection

// Distinct
List<Subject> distinctSubjects = partTimeStudentsSubjectsSelectMany.Distinct().ToList();
distinctSubjects.PrintEntities();

// DistinctBy
List<Subject> distinctByType = partTimeStudentsSubjectsSelectMany.DistinctBy(s => s.Type).ToList();
distinctByType.PrintEntities();



ConsoleHelper.PrintInColor("\n================== Any/All ==================\n", ConsoleColor.Green);

// Any
// Checks if there is at least one item in a collection that follows an expression
// Returns true or false depending on the result
bool hasBob = SEDC.Students.Any(s => s.FirstName == "Bob");
Console.WriteLine("Has Bob " + hasBob);

// All
// Checks if all items of a collection follow a particular expression
// Returns true or false depending on the result
bool areAllAdults = SEDC.Students.All(s => s.Age > 30);
Console.WriteLine(areAllAdults); // False => not all of the students have age > 30



ConsoleHelper.PrintInColor("\n================== Except ==================\n", ConsoleColor.Red);
// Creates a new collection that is missing some particular items
// It returns IEnumerable of the same type as the original collection

List<Student> exceptPartTime = SEDC.Students.Except(SEDC.Students.Where(s => s.IsPartTime)).ToList();
exceptPartTime.PrintEntities();

// List<Student> withWhere = SEDC.Students.Where(s => !s.IsPartTime).ToList(); // same thing...



ConsoleHelper.PrintInColor("\n================== OrderBy/ThenBy (Descending) ==================\n", ConsoleColor.Yellow);
//Orders a collection by a given value
//Can order by ascending - OrderBy and descending - OrderByDescending
//Can have multiple levels of ordering with the ThenBy and ThenByDescending methods
//Returns IEnumerable of the same type as the original collection

SEDC.Students.PrintEntities();
Console.WriteLine();

List<Student> sortedStudentsAsc = SEDC.Students.OrderBy(s => s.FirstName).ToList();
sortedStudentsAsc.PrintEntities();
Console.WriteLine();

List<Student> sortedStudentsDesc = SEDC.Students.OrderByDescending(s => s.FirstName).ToList();
sortedStudentsDesc.PrintEntities();



List<Student> sortedStudentsAscThenBy = SEDC.Students.OrderBy(s => s.FirstName).ThenBy(s => s.Age).ThenBy(s => s.LastName).ToList();
sortedStudentsAscThenBy.PrintEntities();



ConsoleHelper.PrintInColor("\n================== GroupBy ==================\n", ConsoleColor.Green);
// Used to group elements of a sequence based on a key
// It returns a collection of IGrouping<TKey, TElement> objects, where each IGrouping object represents a group and contains a key and a sequence of elements that share that key.

var groupByAcademy = SEDC.Subjects.GroupBy(s => s.Type).ToList();

groupByAcademy[0].ToList().PrintEntities(); // Programming academy subjects
groupByAcademy[1].ToList().PrintEntities(); // Design academy subjects
groupByAcademy[2].ToList().PrintEntities(); // Networks academy subjects



// MANY MORE METHODS ... (Concat, Union, Aggregate, MaxBy, Average...)
// var test = sortedStudentsDesc.Concat(sortedStudentsAscThenBy);


Console.ReadLine();