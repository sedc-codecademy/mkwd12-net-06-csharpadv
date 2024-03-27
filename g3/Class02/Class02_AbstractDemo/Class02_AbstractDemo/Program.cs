using Models;
using System.Security.Cryptography;

namespace Class02_AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Shape s = new Shape("Krug", 1, 1);
            Square s = new Square("Kvadrat", 5);
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.GetInfo());

            Rectangle r = new Rectangle("Shape2", 3, 5);
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(r.GetInfo());


            Rectangle r2 = new Rectangle("Shape3", 3, 8);
            Square s2 = new Square("Kvadrat2", 8);

            //List<Square> list = new List<Square> { s, s2, r, r2 };
            List<Shape> list = new List<Shape> { s, s2, r, r2 };

            foreach (Shape l in list)
            {
                Console.WriteLine(l.CalculateArea());
            }

            List<Square> squares = new List<Square>();
            List<Rectangle> rectangles = new List<Rectangle>();

            foreach (Shape l in list)
            {
                if (l is Square)
                {
                    squares.Add((Square)l);
                }

                if (l is Rectangle)
                {
                    Rectangle rec = (Rectangle)l;
                    //Square squ = (Square)rec;
                    rectangles.Add(rec);
                }
            }

            foreach (Shape l in list)
            {
                //squares.Add((Square)l);
                Square squ = l as Square;
                squares.Add(squ);
            }
        }
    }
}
