using Polymorphism.Domain.Models;
using Polymorphism.Domain.Service;

//Runtime polymorhism
Pet firstPet = new Pet();
firstPet.Name = "PetName";
Console.WriteLine(firstPet.Name);

Pet secondPet = new Cat();
secondPet.Name = "Billy";
//secondPet.Age ///ERROR because secondPet is of type Pet

secondPet.Eat(); //from Cat

firstPet.Eat(); //from Pet

List<Pet> ourPets = new List<Pet>();
Dog dog  = new Dog();
dog.Name = "Sparky";
dog.Color = "Brown";

Cat cat = new Cat();
cat.Name = "Lucy";
cat.Age = 3;

cat.Eat(); //from Cat

Pet pet  = new Pet();
pet.Name = "Barnie";

//Boxing
ourPets.Add(dog);
ourPets.Add(cat);
ourPets.Add(pet);

foreach(Pet p in ourPets)
{
    p.Eat();
}

//Compile time polymorphism
//the idea is that as long as the program knows which method to call, we can have as many combinations as we need
//just the signature has to be different 
PetService petService = new PetService();
petService.PetStatus();
petService.PetStatus("Petko", cat);
petService.PetStatus(cat, "Petko");
petService.PetStatus("Stefan", dog);
petService.PetStatus("Stefan", 25, cat);