using Models.Enums;

namespace Models
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public BreedEnum Breed { get; set; }

        public Dog(string name, string color, int age, BreedEnum breed)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
        }

        public override string GetInfo()
        {
            return $"{Name} ({Color}) - {Age} [{Breed}]";
        }
    }
}
