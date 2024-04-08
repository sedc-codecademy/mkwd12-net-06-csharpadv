using Qinshift.Polymorphism.Domain.Model;
using Qinshift.Polymorphism.Service;

PetService petService = new PetService();


Dog sparky = new Dog() { Id=1, IsGoodBoi=true, Name="Sparky"};
Cat garfild = new Cat() { Id=2, IsLazy=false, Name="Garfild"};

sparky.Eat();
garfild.Eat();

Console.ReadLine();

petService.PetStatus(garfild);
petService.PetStatus(garfild, "Smith");
petService.PetStatus(sparky, "Bob");
petService.PetStatus("Bob", sparky);

Console.ReadLine();