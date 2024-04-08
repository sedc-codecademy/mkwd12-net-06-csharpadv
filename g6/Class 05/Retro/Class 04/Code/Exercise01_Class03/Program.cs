using Exercise01_Class03;

Dog dog1 = new Dog();
dog1.Name = ""; //string.Empty
dog1.Color = "White";
dog1.Id = 4;

dog1.Bark();

//dog.Validate -> static method, cannot be access via an object, we need to use the class
if (Dog.Validate(dog1))
{
    DogShelter.Dogs.Add(dog1);
}

Dog anotherDog  = new Dog();
anotherDog.Name = "Luna";
anotherDog.Color = "Golden";
anotherDog.Id = 5;

if (Dog.Validate(anotherDog))
{
    DogShelter.Dogs.Add(anotherDog);
}

anotherDog.Bark();

DogShelter.PrintAll();