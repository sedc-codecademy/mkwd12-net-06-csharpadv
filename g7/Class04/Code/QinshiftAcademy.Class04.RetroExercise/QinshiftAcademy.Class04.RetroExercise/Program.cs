using QinshiftAcademy.Class04.RetroExercise;
using QinshiftAcademy.Class04.RetroExercise.Models;

Dog dog = new Dog()
{
    Id = 1,
    Name = "",
    Color = "Brown"
};

//since Validate method can work with any dog object, and it gets this object as param, it is marked as static,
//so it is not called via an object, but via the class itself
if (Dog.Validate(dog))
{
    Console.WriteLine("The dog object is valid");
}
else
{
    Console.WriteLine("The dog object is invalid");
}

DogShelter.Dogs.Add(new Dog
{
    Id = 3,
    Name = "Barky",
    Color = "White"
});

DogShelter.PrintAll();
