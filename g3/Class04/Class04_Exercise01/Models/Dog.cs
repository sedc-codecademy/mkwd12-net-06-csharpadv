namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoy, string favoriteFood) : base(name, PetEnum.Dog, age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }

        public override string GetInfo()
        {
            var result =  $"Dog: {Name} ({Age})";

            if (GoodBoy) result += " is good boy";

            return result;
        }
    }
}
