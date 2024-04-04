namespace Generics.Helpers
{
    public class NotGenericListHelper
    {
        public void GoThroughStrings(List<string> strings)
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            Console.WriteLine($"This list has {strings.Count} members and of type {first.GetType().Name}!");
        }

        public void GoThroughIntegers(List<int> ints)
        {
            foreach(int num in ints)
            {
                Console.WriteLine(num);
            }
        }

        public void GetInfoForIntegers(List<int> ints)
        {
            int first = ints[0];
            Console.WriteLine($"This list has {ints.Count} members and of type {first.GetType().Name}!");
        }

        public void GoThroughBooleans(List<bool> bools)
        {
            foreach (bool boolean in bools)
            {
                Console.WriteLine(boolean);
            }
        }

        public void GetInfoForBooleans(List<bool> bools)
        {
            bool first = bools[0];
            Console.WriteLine($"This list has {bools.Count} members and of type {first.GetType().Name}!");
        }
    }
}
