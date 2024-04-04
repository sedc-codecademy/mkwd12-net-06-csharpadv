namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        //public static void GoThrough<T>(this List<T> items) 
        public static void NasaMetoda<T>(this List<T> items) 
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static string ToCommaSeparatedString(this List<string> items)
        {
            return string.Join(",", items);
        }
    }
}
