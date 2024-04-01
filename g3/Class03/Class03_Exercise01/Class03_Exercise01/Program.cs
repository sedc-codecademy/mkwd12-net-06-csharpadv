
using Models;

namespace Class03_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog(1, "Dog1", "black");
            var dog2 = new Dog(2, "Dog2", "brown");
            var dog3 = new Dog(3, "Dog3", "white");
            var dog4 = new Dog(4, "D", "black");
            var dog5 = new Dog(-1, "Dog5", "brown");

            DogShelter.AddDog(dog1);
            DogShelter.AddDog(dog2);
            DogShelter.AddDog(dog3);

            try
            {
                DogShelter.AddDog(dog4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DogShelter.AddDog(dog5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(DogShelter.GetAllDogs());
        }
    }
}
