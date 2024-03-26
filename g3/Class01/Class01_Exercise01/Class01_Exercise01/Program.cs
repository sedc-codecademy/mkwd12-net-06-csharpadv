namespace Class01_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the words that you are searching for: (after every word press enter)");
            Console.WriteLine("If you want to finish enter 'x'");
            bool proceedWithEnteringNames = true;
            List<string> words = new List<string>();

            while (proceedWithEnteringNames)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input.Trim()))
                {
                    continue;
                }

                if (string.Equals(input, "x", StringComparison.InvariantCultureIgnoreCase))
                {
                    proceedWithEnteringNames = false;
                    continue;
                }

                words.Add(input.Trim());
            }

            words = words.Distinct().ToList();

            Console.WriteLine("Please enter the text:");
            string text = Console.ReadLine();

            Dictionary<string, int> stats = new Dictionary<string, int>();

            words.ForEach(x => stats.Add(x, 0));

            //List<string> textWords = text.Replace(".", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> textWords = text.Split(new[] { ' ', '.', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string word in stats.Keys)
            {
                int occurance = textWords.Count(x => string.Equals(x, word, StringComparison.InvariantCultureIgnoreCase));

                stats[word] = occurance;
            }

            Console.WriteLine("Stats:");
            foreach (KeyValuePair<string, int> stat in stats)
            {
                Console.WriteLine($"{stat.Key} = {stat.Value}");
            }
        }
    }
}
