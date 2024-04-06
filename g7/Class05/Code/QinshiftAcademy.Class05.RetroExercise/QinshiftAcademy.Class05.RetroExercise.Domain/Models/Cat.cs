

using QinshiftAcademy.Class05.RetroExercise.Domain.Enums;

namespace QinshiftAcademy.Class05.RetroExercise.Domain.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool isLazy, int livesLeft) : base (name, PetType.Cat, age)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()}, with lives left: {LivesLeft}");

            if (IsLazy)
            {
                Console.WriteLine("This cat is lazy");
            }
            else
            {
                Console.WriteLine("This cat is not lazy");
            }
        }
    }
}
