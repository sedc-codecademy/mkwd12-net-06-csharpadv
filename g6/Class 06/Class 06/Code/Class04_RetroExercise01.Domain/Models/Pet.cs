using Class04_RetroExercise01.Domain.Enums;
using Class04_RetroExercise01.Domain.Models;

//Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
//Dog(from Pet ) with GoodBoy and FavoriteFood
//Cat( from Pet ) with Lazy and LivesLeft
//Fish( from Pet ) with color, size


namespace Class04_RetroExercise01.Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }    

        public PetTypeEnum Type { get; set; }

        public abstract void PrintInfo();

        public Pet(string name, int age, PetTypeEnum type)
        {
            Name = name;
            Age = age;
            Type = type;
        }   
    }
}
