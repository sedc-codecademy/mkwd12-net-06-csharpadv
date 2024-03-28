namespace Models
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public float A { get; set; }
        //public float B { get; set; }

        protected Shape(string name, float a/*, float b*/)
        {
            Name = name;
            A = a;
            //B = b;
        }

        public abstract float CalculateArea();

        public virtual string GetInfo()
        {
            return $"{Name}: {CalculateArea()}";
        }
    }
}
