namespace Generics.Helpers
{
    public class GenericListHelper
    {
        public void GoThroughList<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetListInfo<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and of type {first.GetType().Name}!");
        }
    }
}
