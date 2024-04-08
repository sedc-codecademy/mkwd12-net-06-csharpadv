

using QinshiftAcademy.Class05.RetroExercise.Domain.Enums;

namespace QinshiftAcademy.Class05.RetroExercise.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()}, aged {Age} and its favourite food is {FavouriteFood}");
        }


        public Dog(string name, int age, string favouriteFood) : base(name, PetType.Dog, age)
        {
            FavouriteFood = favouriteFood;
        }
    }
}
