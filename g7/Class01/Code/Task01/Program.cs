List<string> words = new List<string>();

string input = string.Empty;
do
{
    Console.WriteLine("Please enter a word:");
    string word = Console.ReadLine();

    //todo validation if the input is empty

    words.Add(word);

    Console.WriteLine("If you want to enter another word press any other key then X");
    input = Console.ReadLine();
} while (input != "x" && input != "X");

Console.WriteLine("Please enter the text:");
string text = Console.ReadLine();

List<string> textWords = text.Split(" ").ToList();

foreach (string word in words)
{
    //int wordCount = textWords
    //    .Where(x => string.Equals(x, word, StringComparison.InvariantCultureIgnoreCase)).ToList().Count;

    int wordCount = textWords.Count(x => string.Equals(x, word, StringComparison.InvariantCultureIgnoreCase));
    //int wordCount = textWords.Count(x => x.ToLower() == word.ToLower());

    //nice to have - Dictionary -> key of type string (word), value of type int (count)
    Console.WriteLine($"{word}: {wordCount}");
}