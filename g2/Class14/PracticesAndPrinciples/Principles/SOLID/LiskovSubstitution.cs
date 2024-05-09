namespace Principles.SOLID
{
    /*
         *** LISKOV SUBSTITUTION PRINCIPLE ***

         => LSP states that the child class should be perfectly substitutable for their parent class.
      */


    #region Without LSP
    // BAD EXAMPLE
    public class TriangleWithoutLSP
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleWithoutLSP : TriangleWithoutLSP
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AppStartWithoutLSP
    {
        public static void Main()
        {
            TriangleWithoutLSP triangle = new CircleWithoutLSP();
            Console.WriteLine(triangle.GetShape()); // will print Circle
        }
    }

    #endregion

    #region With LSP
    // GOOD EXAMPLE

    #endregion

}
