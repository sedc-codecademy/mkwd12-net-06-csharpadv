using AbstractAndInterface.Entities.Interfaces;

namespace AbstractAndInterface.Entities.Models.BaseModel
{
    /*
       *Abstract Class* => A class declared with the abstract keyword. It may contain abstract members, non-abstract members, constructors etc.

       *Abstract Member* => A member (method, property) declared in an abstract class without providing an implementation. Abstract members are intended to be implemented by derived classes.

       *Usecase* => Abstract classes are often used as base classes for inheritance. 
   */
    public abstract class Human : IHuman
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        //public string Gender { get ; set ; } 

        //public abstract string Test {  get; set; } // rarely used

        public Human(string firstName, string lastName, int age, long phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        // Abstract method => the derived (child) classes MUST provide implementation
        public abstract string GetInfo();

        // Not abstract method => will be inherited as is
        public string GetFullName() 
        {
            return $"{FirstName} {LastName}";
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {GetFullName()}");
        }
    }
}
