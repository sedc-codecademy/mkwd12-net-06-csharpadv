using Class04_RetroExercise01.Domain.Enums;

namespace Class04_RetroExercise01.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()}, aged {Age} whose favourite food is {FavouriteFood}");
        }

        public Dog(string name, int age, string favouriteFood) : base(name, age, PetTypeEnum.Dog)
        {
            FavouriteFood = favouriteFood;
        }
    }
}
