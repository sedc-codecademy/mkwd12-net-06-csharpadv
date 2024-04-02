namespace Models
{
    public class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public string Bark()
        {
            return $"{Name}: Bark Bark";
        }

        //public string GetInfo()
        //{
        //    return Bark();
        //}
    }
}
