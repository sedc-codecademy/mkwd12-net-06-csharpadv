

using QinshiftAcademy.Class05.RetroExercise.Domain.Enums;

namespace QinshiftAcademy.Class05.RetroExercise.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, int age, string color, int size) 
            : base(name, PetType.Fish, age)
        {
            Size = size;
            Color = color;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()}, it is of color {Color} and Size {Size}");
        }
    }
}
