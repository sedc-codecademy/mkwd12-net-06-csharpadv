namespace Class04_ExtensionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "We are students from SEDC academy.";

            Console.WriteLine(StringHelper.AddQuotes(text));
            Console.WriteLine(StringHelper.RemoveWordsFromBegining(text, 3));

            Console.WriteLine(text.AddQuotes());
            Console.WriteLine(text.RemoveWordsFromBegining(3).AddQuotes());
        }
    }
}
