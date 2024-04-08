using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Polymorphism.Domain.Model
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating!");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from cat {Name}");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello from cat {name}");

        }
    }
}
