using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy) : base(name, PetEnum.Cat, age)
        {
            LivesLeft = 9;
            Lazy = lazy;
        }

        public override string GetInfo()
        {
            return $"Cat: {Name} ({Age}), lives left: {LivesLeft}";
        }
    }
}
