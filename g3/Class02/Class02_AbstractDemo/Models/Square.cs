namespace Models
{
    public class Square : Shape
    {
        public Square(string name, float a) : base(name, a/*, a*/)
        {
            
        }

        public override float CalculateArea()
        {
            return A * A;
        }

        public override string GetInfo()
        {
            return $"{CalculateArea()} m2";
        }
    }
}
