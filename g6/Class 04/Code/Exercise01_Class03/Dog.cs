//Id, Name, Color, Bark() - Prints “Bark Bark”
//A static method Validate() -Checks if dog has all 3 properties, if Id is not less than 0 and Name is 2 characters or longer


using System.Globalization;

namespace Exercise01_Class03
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate(Dog dog)
        {
            if(dog == null) 
             return false;

            if(dog.Id == null || string.IsNullOrEmpty(dog.Name) || string.IsNullOrEmpty(dog.Color))
                return false;

            if(dog.Id < 0) 
                return false;

            if(dog.Name.Length < 2)
                return false;

            return true; //if it did not return in any of the previous cases, the dog is valid
        }
    }
}
