using Class04_RetroExercise01.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_RetroExercise01.Domain
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
                pet.PrintInfo(); //we can call PrintInfo because our T will inherit from Pet and it must have a PrintInfo method
            }
        }

        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (pet == null)
            {
                Console.WriteLine($"There is no pet named {name}");
                // return;
            }
            else
            {
                Pets.Remove(pet);
                Console.WriteLine($"Your new pet is {name}");
            }
        }
    }
}
