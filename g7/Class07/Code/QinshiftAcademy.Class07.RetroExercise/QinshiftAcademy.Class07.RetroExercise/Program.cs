//find all the person firstNames that start with an R, ordered by person age - desc

using QinshiftAcademy.Class07.RetroExercise;
using QinshiftAcademy.Class07.RetroExercise.Models;

List<string> firstNames = Database.People.Where(x => x.FirstName.StartsWith("R")) //filter
    .OrderByDescending(x => x.Age) //order in desc way
    .Select(x => x.FirstName)
    //.OrderByDescending(x => x.Age) //be careful what does each of the LINQ methods return
    //for example, Select returns a list of strings in this case, so we can't order by Age
    .ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}

//Find and print all the names and ages of brown dogs older than 3, ordered by age asc
List<string> dogsNames = Database.Dogs.Where(x => x.Color == "Brown" && x.Age > 3) //filter
            .OrderBy(x => x.Age)
            .Select(x => $"{x.Name} {x.Age}").ToList();
Console.WriteLine("===============");
foreach (string dogName in dogsNames)
{
    Console.WriteLine(dogName);
}

//Find all people with more than two dogs, ordered by name desc
List<Person> peopleWithTwoOrMoreDogs = Database.People.Where(x => x.Dogs.Count > 2)
                                                    .OrderByDescending(x => x.FirstName).ToList();

Console.WriteLine("=============");
foreach (Person p in peopleWithTwoOrMoreDogs)
{
    Console.WriteLine($"{p.FirstName} {p.Dogs.Count}");
}

//Find Fredy's dogs' names where the dogs are older than 1
Person freddy = Database.People.First(x => x.FirstName == "Freddy");
List<Dog> freddysDogs = freddy.Dogs;
List<string> freddysDogsNames = freddysDogs.Where(x => x.Age > 1)
    .Select(x => x.Name).ToList();

//List<string> freddysDogsNames = Database.People.First(x => x.FirstName == "Freddy").Dogs.Where(x => x.Age > 1)
//    .Select(x => x.Name).ToList();
Console.WriteLine("===============");
foreach (string dogName in freddysDogsNames)
{
    Console.WriteLine(dogName);
}

//Get Nathen's first dog
Person nathen = Database.People.FirstOrDefault(x => x.FirstName == "Nathen");
if (nathen != null)
{
    // Dog firstDog = nathen.Dogs[0];
    Dog firstDog = nathen.Dogs.First(); //if the collection is empty this will give an error

    //smarter way
    Dog nathensFirstDog = nathen.Dogs.FirstOrDefault();
    if (nathensFirstDog == null)
    {
        Console.WriteLine("Nathen doesn't own dogs!!!");
    }
    else
    {
        Console.WriteLine($"Nathen's first dog is {nathensFirstDog.Name}");
    }
}

//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name asc
List<Person> fourPeople = Database.People.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy"
                                                || x.FirstName == "Erin" || x.FirstName == "Amelia").ToList();

List<Dog> dogs = fourPeople.SelectMany(x => x.Dogs).ToList(); //we want to get a flat list of all the dogs of these four people

List<string> names = dogs.Where(x => x.Color == "White")
    .OrderBy(x => x.Name)
    .Select(x => x.Name).ToList();

//List<string> names = Database.People.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy"
//                                                || x.FirstName == "Erin" || x.FirstName == "Amelia")
//               .SelectMany(x => x.Dogs)
//               .Where(x => x.Color == "White")
//               .OrderBy(x => x.Name)
//               .Select(x => x.Name).ToList();