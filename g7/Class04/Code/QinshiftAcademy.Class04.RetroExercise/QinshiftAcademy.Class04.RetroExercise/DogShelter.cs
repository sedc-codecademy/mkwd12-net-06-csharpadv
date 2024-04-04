

using QinshiftAcademy.Class04.RetroExercise.Models;

namespace QinshiftAcademy.Class04.RetroExercise
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>();
            Dogs.Add(new Dog()
            {
                Id = 1,
                Name = "Barnie",
                Color = "Brown"
            });

            Dog dog = new Dog()
            {
                Id = 2,
                Name = "Sparky",
                Color = "Black"
            };
            Dogs.Add(dog);
        }

        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Id} {dog.Name} {dog.Color}");
            }
        }
    }
}
