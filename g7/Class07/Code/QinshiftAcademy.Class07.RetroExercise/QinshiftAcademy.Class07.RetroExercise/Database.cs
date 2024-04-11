using QinshiftAcademy.Class07.RetroExercise.Enums;
using QinshiftAcademy.Class07.RetroExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class07.RetroExercise
{
    public static class Database
    {
        public static List<Dog> Dogs = new List<Dog>()
        {
            new Dog("Charlie", "Black", 3, Breed.Collie), // 0
            new Dog("Buddy", "Brown", 1, Breed.Doberman),
            new Dog("Max", "Olive", 1, Breed.Plott),
            new Dog("Archie", "Black", 2, Breed.Mutt),
            new Dog("Oscar", "White", 1, Breed.Mudi),
            new Dog("Toby", "Maroon", 3, Breed.Bulldog), // 5
            new Dog("Ollie", "Silver", 4, Breed.Dalmatian),
            new Dog("Bailey", "White", 4, Breed.Pointer),
            new Dog("Frankie", "Gray", 2, Breed.Pug),
            new Dog("Jack", "Black", 5, Breed.Dalmatian),
            new Dog("Chanel", "Black", 1, Breed.Pug), // 10
            new Dog("Henry", "White", 7, Breed.Plott),
            new Dog("Bo", "Maroon", 1, Breed.Boxer),
            new Dog("Scout", "Olive", 2, Breed.Boxer),
            new Dog("Ellie", "Brown", 6, Breed.Doberman),
            new Dog("Hank", "Silver", 2, Breed.Collie), // 15
            new Dog("Shadow", "Silver", 3, Breed.Mudi),
            new Dog("Diesel", "Brown", 4, Breed.Bulldog),
            new Dog("Abby", "Black", 1, Breed.Dalmatian),
            new Dog("Trixie", "White", 8, Breed.Pointer), // 19
        };

        public static List<Person> People = new List<Person>()
        {
            new Person("Nathanael", "Holt", 20, Job.Choreographer),
            new Person("Rick", "Chapman", 35, Job.Dentist),
            new Person("Oswaldo", "Wilson", 19, Job.Developer),
            new Person("Kody", "Walton", 43, Job.Sculptor),
            new Person("Andreas", "Weeks", 17, Job.Developer),
            new Person("Kayla", "Douglas", 28, Job.Developer),
            new Person("Richie", "Campbell", 19, Job.Waiter),
            new Person("Soren", "Velasquez", 33, Job.Interpreter),
            new Person("August", "Rubio", 21, Job.Developer),
            new Person("Rocky", "Mcgee", 57, Job.Barber),
            new Person("Emerson", "Rollins", 42, Job.Choreographer),
            new Person("Everett", "Parks", 39, Job.Sculptor),
            new Person("Amelia", "Moody", 24, Job.Waiter)
            { Dogs = new List<Dog>() {Dogs[16], Dogs[18] } },
            new Person("Emilie", "Horn", 16, Job.Waiter),
            new Person("Leroy", "Baker", 44, Job.Interpreter),
            new Person("Nathen", "Higgins", 60, Job.Archivist)
            { Dogs = new List<Dog>(){ Dogs[6], Dogs[0] } },
            new Person("Erin", "Rocha", 37, Job.Developer)
            { Dogs = new List<Dog>() { Dogs[2], Dogs[3], Dogs[19] } },
            new Person("Freddy", "Gordon", 26, Job.Sculptor)
            { Dogs = new List<Dog>() { Dogs[4], Dogs[5], Dogs[10], Dogs[12], Dogs[13] } },
            new Person("Valeria", "Reynolds", 26, Job.Dentist),
            new Person("Cristofer", "Stanley", 28, Job.Dentist)
            { Dogs = new List<Dog>() { Dogs[9], Dogs[14], Dogs[15] } }
        
        
        };
    }
}
