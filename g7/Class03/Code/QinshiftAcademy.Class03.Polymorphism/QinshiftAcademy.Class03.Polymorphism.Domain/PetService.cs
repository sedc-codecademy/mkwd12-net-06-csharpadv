

using QinshiftAcademy.Class03.Polymorphism.Domain.Models;
using System.Xml.Linq;

namespace QinshiftAcademy.Class03.Polymorphism.Domain
{
    //in this class we will have several methods with same name but different signature (different types and/or number of parameters)
    public class PetService
    {
        public void PetStatus()
        {
            Console.WriteLine("PetStatus method without parameters");
        }

        //ERROR, we can't have a method with the same signature twice
        //the code won't know which one to call
        //public string PetStatus()
        //{

        //}

        public void PetStatus(string name)
        {
            Console.WriteLine($"Hello {name}. Calling from PetStatus method");
        }

        public void PetStatus(int id)
        {
            Console.WriteLine($"Id: {id}. Calling from PetStatus method");
        }

        public void PetStatus(int id, string name)
        {
            Console.WriteLine($"Hello {name}. Id: {id}. Calling from PetStatus method");
        }

        public string PetStatus(Cat cat)
        {
            return $"Cat: {cat.Name} {cat.Age}";
        }
    }
}
