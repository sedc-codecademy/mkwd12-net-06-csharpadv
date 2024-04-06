using QinshiftAcademy.Class05.RetroExercise.Domain;
using QinshiftAcademy.Class05.RetroExercise.Domain.Models;

PetStore<Dog> dogPetStore = new PetStore<Dog>();
dogPetStore.Pets.Add(new Dog("Barkie", 3, "Bacon"));
dogPetStore.Pets.Add(new Dog("Sparky", 5, "Meat"));

Console.WriteLine("Dogs in our database:");
dogPetStore.PrintPets();

PetStore<Cat> catPetStore = new PetStore<Cat>();
catPetStore.Pets.Add(new Cat("Bella", 2, true, 9));

catPetStore.PrintPets();

dogPetStore.BuyPet("Barkie");

dogPetStore.PrintPets();