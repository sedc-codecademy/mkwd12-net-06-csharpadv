using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rectangle : Shape
    {
        public float B { get; set; }

        public Rectangle(string name, float a, float b) : base(name, a)
        {
            B = b;
        }

        public override float CalculateArea()
        {
            return A * B;
        }
    }
}
