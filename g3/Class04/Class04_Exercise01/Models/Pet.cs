namespace Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetEnum Type { get; set; }
        public int Age { get; set; }

        public Pet(string name, PetEnum type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public abstract string GetInfo();
    }
}
