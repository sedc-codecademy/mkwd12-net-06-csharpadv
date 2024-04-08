

using QinshiftAcademy.Class05.RetroExercise.Domain.Models;

namespace QinshiftAcademy.Class05.RetroExercise.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }

        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets()
        {
            foreach(T pet in Pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T petDb = Pets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

            if(petDb == null)
            {
                Console.WriteLine($"There is no pet called {name}");
                return;
            }

            Pets.Remove(petDb);
            Console.WriteLine($"The pet was removed");
        }
    }
}
