namespace Models
{
    public class Fish : Pet
    {
        public decimal Size { get; set; }
        public string Color { get; set; }

        public Fish(string name, int age, string color, decimal size) : base(name, PetEnum.Fish, age)
        {
            Color = color;
            Size = size;
        }

        public override string GetInfo()
        {
            return $"Fish: {Name} ({Age}) - {Color}";
        }
    }
}
