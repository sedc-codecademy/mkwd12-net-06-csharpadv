// Ask for names until 'x' is entered
using Qinshift.Exercises01SecondWay.Domain.Models;
using Qinshift.Exercises01SecondWay.Services;

Console.WriteLine("Enter names (type 'x' to stop):");
List<string> names = GetUserInputNames();

// Ask for text
Console.WriteLine("Enter a text:");
string text = Console.ReadLine();

// Count occurrences of each name in the text
foreach (string name in names)
{
    int count = CountNameOccurrences(text, name);
    Console.WriteLine($"The name '{name}' appears {count} time(s) in the text.");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();


static List<string> GetUserInputNames()
{
    List<string> names = new List<string>();
    while (true)
    {
        string name = Console.ReadLine().Trim();
        if (name.ToLower() == "x") break;
        names.Add(name);
    }
    return names;
}

static int CountNameOccurrences(string text, string name)
{
    int count = 0;
    int index = text.IndexOf(name, StringComparison.OrdinalIgnoreCase);
    while (index != -1)
    {
        count++;
        index = text.IndexOf(name, index + name.Length, StringComparison.OrdinalIgnoreCase);
    }
    return count;
}


// ================= SECOND WAY ========================
// Ask for names until 'x' is entered
Console.WriteLine("Enter names (type 'x' to stop):");
List<string> secondsNames = GetUserInputNames();

// Ask for text
Console.WriteLine("Enter a text:");
string anotherText = Console.ReadLine();

SearchService searchService = new SearchService();

List<SearchResult> searchResults = searchService.CountAppearancesInText2(anotherText, secondsNames);

foreach (SearchResult item in searchResults)
{
    Console.WriteLine($"Name: {item.Name} is contained {item.Appearance}");
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();