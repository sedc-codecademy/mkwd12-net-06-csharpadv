namespace Generics.Helpers
{
    /// <summary>
    ///     Class with generic methods.
    ///     Generic Methods allow you to write methods that can operate on any data type.
    /// </summary>
    public class GenericListHelper
    {
        // SYNTAX: [access modifier] [return type] [method name]<T> ([parameters])
        public void GoThroughList<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        // works as well with static methods
        public static void GetListInfo<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and of type {first.GetType().Name}!");
        }
    }
}
