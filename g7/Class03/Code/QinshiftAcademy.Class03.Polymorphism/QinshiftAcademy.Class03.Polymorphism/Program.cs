using QinshiftAcademy.Class03.Polymorphism.Domain;
using QinshiftAcademy.Class03.Polymorphism.Domain.Models;

//RUNTIME POLYMORPHISM
Cat cat = new Cat();
cat.Name = "Bella";
cat.Color = "white";
cat.Eat(); //the implementation from the Cat class will be called

Pet petCat = new Cat();
//petCat.Age = 5; //ERROR - petCat variale is of type Pet
petCat.Eat(); //the implementation from the Cat class will be called, because the assigned object is of type Cat

//down casting in order to get the real cat object that is saved in the variable of type Pet
((Cat)petCat).Age = 10;

//all the members of this list need to be of type Pet, or some of the inherited types Cat or Dog
List<Pet> pets = new List<Pet>();

pets.Add(new Pet()
{
    Name = "Sparky",
    Color = "Brown"
});

pets.Add(cat);

pets.Add(new Dog()
{
    Name = "Barnie"
});

foreach(Pet pet in pets)
{
    pet.Eat();
}


Console.WriteLine("====COMPILE TIME POLYMORPHISM====");

PetService petService = new PetService();

//here C# will look for a method called PetStatus without parameters
petService.PetStatus();

//here C# will look for a method called PetStatus with one parameter of type string
petService.PetStatus("Barnie");

//here C# will look for a method called PetStatus with one parameter of type int
petService.PetStatus(5);

