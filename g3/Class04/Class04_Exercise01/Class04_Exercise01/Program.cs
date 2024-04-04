using Models;

namespace Class04_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog("Sharko", 1, true, "pashteta");
            Console.WriteLine(d.GetInfo());
            Console.WriteLine("------------------");
            //Console.WriteLine(DogExtension.GetDogInfo(d));
            Console.WriteLine(d.GetDogInfo());
            var d2 = new Dog("Murdzo", 2, false, "7mica");

            var dogStore = new PetStore<Dog>("Shop Dogs");
            var catStore = new PetStore<Cat>("Store Cats");
            dogStore.AddPet(d);
            dogStore.AddPet(d2);
            //dogStore.AddPet(d2);
            Console.WriteLine("------------------");
            Console.WriteLine(dogStore.GetPets());
            dogStore.BuyPet("Sharko");
            Console.WriteLine("------------------");
            Console.WriteLine(dogStore.GetPets());


            Dog d3 = dogStore.BuyPet("Bark");

            if(d3 == null)
            {
                Console.WriteLine("Dog with that name does not exist");
            }
            Console.WriteLine("------------------");
            Console.WriteLine(dogStore.GetPets());
        }
    }
}
