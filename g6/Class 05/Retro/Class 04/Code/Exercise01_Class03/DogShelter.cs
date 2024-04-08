//Create a static class called DogShelter that has:
//List of Dogs
//PrintAll() - prints all dogs from List of Dogs


namespace Exercise01_Class03
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog()
                {
                    Id = 1,
                    Name = "Barky",
                    Color = "Black"
                },
                new Dog()
                {
                    Id = 2,
                    Name = "Sparky",
                    Color = "Brown"
                },
                new Dog()
                {
                    Id = 3,
                    Name = "Hera",
                    Color  = "Black"
                }
            };
        }


        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} {dog.Color}");
            }
        }
    }
}

