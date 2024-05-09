namespace Class14.Examples.GoodPractices
{
    public class Loops
    {
        List<string> strings = new List<string>() { "Bob", "Jill", "Jake", "Greg", "Maximilian", "Anne"};

        public void LoopExamples()
        {
            // print all the names that are the same length of the list
            //bad example
            for(int counter = 0; counter < strings.Count; counter++)
            {
                if (strings[counter].Length == strings.Count)
                {
                    Console.WriteLine(strings[counter]);
                }
            }

            //good example
            int listLength = strings.Count;
            for (int i = 0; i <listLength; i++)
            {
                if (strings[i].Length == listLength)
                {
                    Console.WriteLine(strings[i]);
                }
            }
        }
    }
}
