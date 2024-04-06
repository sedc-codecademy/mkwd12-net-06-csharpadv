

using QinshiftAcademy.Class05.RetroExercise.Domain.Enums;

namespace QinshiftAcademy.Class05.RetroExercise.Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Age { get; set; }

        public abstract void PrintInfo();

        public Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;    
            Age = age;
        }
    }
}
