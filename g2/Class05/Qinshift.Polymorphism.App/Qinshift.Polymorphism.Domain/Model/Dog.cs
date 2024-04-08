using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Polymorphism.Domain.Model
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public override void Eat()
        {
            Console.WriteLine("nom nom on dog food!");
        }

        public override string PrintInfo()
        {
            return $"{Id} - {Name}";
        }
    }
}
