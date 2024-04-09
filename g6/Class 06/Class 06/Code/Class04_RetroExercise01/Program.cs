using Class04_RetroExercise01.Domain;
using Class04_RetroExercise01.Domain.Models;

PetStore<Dog> dogPetStore = new PetStore<Dog>();
dogPetStore.Pets.Add(new Dog("Sparky", 3, "Bacon"));
dogPetStore.Pets.Add(new Dog("Lucy", 2, "Meat"));

Console.WriteLine("Dogs in our pet store:");
dogPetStore.PrintPets();

PetStore<Pet> petStore = new PetStore<Pet>();
petStore.Pets.Add(new Dog("Hera", 3, "Bacon"));
petStore.Pets.Add(new Cat("Lea", 2, false, 8));
petStore.Pets.Add(new Cat("Bella", 3, true, 7));

Console.WriteLine("Welcome to our pet store:");
petStore.PrintPets();

petStore.BuyPet("Bella");

petStore.PrintPets();