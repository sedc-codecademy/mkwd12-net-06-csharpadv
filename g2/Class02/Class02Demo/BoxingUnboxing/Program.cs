internal class Program
{
    private static void Main(string[] args)
    {
        #region Boxing/Unboxing
        // *BOXING* => process of converting a value type to a reference type.
        // *UNBOXING* => process of converting a reference type to a value type

        // Boxing an integer in to a more universal type, object
        // All value types derive from object
        // That is why we can box any value type in to object
        int number1 = 9000;
        object obj1 = number1;
        Console.WriteLine(obj1); // works

        // Unboxing an object back in to integer
        // Since an object variable can hold any value we can try and unbox it to a specific type
        object obj2 = 9000;
        int number2 = (int)obj2; // -> This change of type is called casting
        Console.WriteLine(number2); // works
        Console.ReadLine();

        // Note: Casting changes the type, but does not change the object value
        // It is different than converting since converting tries to change the value to match another type
        // Casting just changes the type if the value is eligable to exist in that type as well
        // A good example is unboxing since object and int can both hold the number 9000
        // There is no need to change the number since it can exist in both of the types
        #endregion
    }
}