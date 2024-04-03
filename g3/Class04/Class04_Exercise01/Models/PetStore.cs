using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PetStore<T> where T : Pet
    {
        public string Name { get; set; }

        public PetStore(string name)
        {
            Name = name;
        }

        private List<T> Pets { get; set; } = new List<T>();

        //public PetStore()
        //{
        //    Pets = new List<T>();
        //}

        public string GetPets()
        {
            string result = "List of pets:\n";
            return result + string.Join("\n", Pets.Select(x => x.GetInfo()).ToList());
        }

        public T BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if(pet != null)
            {
                Pets.Remove(pet);
            }

            return pet;
        }

        public void AddPet(T pet)
        {
            if(Pets.Any(x => x.Name.ToLower() == pet.Name.ToLower()))
            {
                throw new Exception($"Pet with name: {pet.Name} already exists");
            }

            Pets.Add(pet);
        }
    }
}
