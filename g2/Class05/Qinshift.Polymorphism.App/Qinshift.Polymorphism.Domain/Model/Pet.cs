using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Polymorphism.Domain.Model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }

        public virtual string PrintInfo()
        {
            return string.Empty;
        }
    }
}
