namespace Class04_GenericDemo
{
    public class ListHelper
    {
        //public static void PrintItem(List<int> items)
        //{
        //    foreach (int item in items)
        //    {
        //        Console.WriteLine($"{item}");
        //    }
        //}

        //public static void PrintItem(List<string> items)
        //{
        //    foreach (string item in items)
        //    {
        //        Console.WriteLine($"{item}");
        //    }
        //}

        public static void PrintItem<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void PrintUserItem<T>(List<T> items) where T : User
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
