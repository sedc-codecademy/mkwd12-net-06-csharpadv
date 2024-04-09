using Polymorphism.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Domain.Service
{
    //Compile time polymorphism
    //Having methods with the same name
    //but they have different signature
    public class PetService
    {
        public void PetStatus()
        {
            Console.WriteLine("PetStatus without params");
        }

        //ERROR
        //When calling the method, we don't specify the return type so the program won't know which method to call
        //public string PetStatus()
        //{
        //    return "";
        //}

        //the name of the method is the same, but it has two params - first is of type string, second is of type Cat
        public void PetStatus(string name, Cat cat)
        {
            Console.WriteLine($"Hello {name}. The cat {cat.Name} is {cat.Age} years old");
        }

        //the name of the method is the same, but it has two params - first is of type Cat, second is of type string
        //THE ORDER OF THE PARAMS IS IMPORTANT!
        public void PetStatus(Cat cat, string name)
        {
            Console.WriteLine($"The cat {cat.Name} is {cat.Age} years old. Hello {name}");
        }

        public void PetStatus(string name, Dog dog)
        {
            Console.WriteLine($"Hello {name}. The dog {dog.Name} is {dog.Color}");
        }

        public void PetStatus(string name, int age, Cat cat)
        {
            Console.WriteLine($"Hello {name}. You are {age} years old. The cat {cat.Name} is {cat.Age} years old");
        }


    }
}
