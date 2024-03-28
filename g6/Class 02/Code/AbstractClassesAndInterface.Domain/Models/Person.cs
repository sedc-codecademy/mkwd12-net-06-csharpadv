using AbstractClassesAndInterface.Domain.Interfaces;

namespace AbstractClassesAndInterface.Domain.Models
{
    public abstract class Person : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public Person()
        {

        }
        //we don't use the person constructor to create instances of Person, but we use it in the derived classes when we call the base constructor
        public Person(string fullName, int age, string address, long phoneNumber)
        {
            FullName = fullName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //this method does not have an implementation in this (base) class. All classes that inherit from this class
        //MUST provide an implementation for this method
        public abstract string GetProfessionalInfo();

        public void GetInfo()
        {
            Console.WriteLine($"{FullName} : {PhoneNumber}");
        }

        //must implement them because Person implements IPerson interface
        public void Greet()
        {
            Console.WriteLine($"Hello from {FullName}");
        }

        public void SendGift(string nameOfGift)
        {
            Console.WriteLine($"Sending {nameOfGift} from {Address}");
        }
    }
}
