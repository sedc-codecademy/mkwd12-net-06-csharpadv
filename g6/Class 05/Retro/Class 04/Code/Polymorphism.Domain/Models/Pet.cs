using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Domain.Models
{
    public class Pet
    {
        public string Name { get; set; }
        //{
        //    get
        //    {
        //        Console.WriteLine("Getting the name");

        //        return Name;
        //    }

        //    set
        //    {
        //        Name = value;
        //    }
        //}

        public virtual void Eat()
        {
            Console.WriteLine("Calling Eat method from Pet class");
        }
    }
}
