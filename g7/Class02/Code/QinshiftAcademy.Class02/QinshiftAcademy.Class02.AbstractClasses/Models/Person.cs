

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    //You can not instantiate objects from a class that is marked as abstract
    //We just use this class to store common properties and methods, but also store method signatures
    //in order to obligate the inherited classes to provide implementations for them
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

        //this constructor will be called as base constructor from the inherited classes
        public Person(string firstName, string lastName, long phoneNumber, string address)
        {
            //here we can have some validation
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void TestMethod()
        {
            Console.WriteLine("This method has implementation and will be inherited further");
        }

        //This method doesn't have implementation in the base (abstract) class. But it MUST have implementation
        //in the inherited classes
        public abstract void PrintInfo();
    }
}
