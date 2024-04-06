using Qinshift.Polymorphism.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Polymorphism.Service
{
    public class PetService
    {
        public void PetStatus(Dog dog, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (dog.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi!");
            }
            else
            {
                Console.WriteLine("This dog is a not good boi!");
            }
        }

        public void PetStatus(string ownerName, Dog dog)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (dog.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi!");
            }
            else
            {
                Console.WriteLine("This dog is a not good boi!");
            }
        }

        public void PetStatus(Cat cat, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (cat.IsLazy)
            {
                Console.WriteLine("This cat is a very lazy!");
            }
            else
            {
                Console.WriteLine("This cat is a not lazy!");
            }
        }

        public void PetStatus(Cat cat)
        {
            if (cat.IsLazy)
            {
                Console.WriteLine("This cat is a very lazy!");
            }
            else
            {
                Console.WriteLine("This cat is a not lazy!");
            }
        }
    }
}
