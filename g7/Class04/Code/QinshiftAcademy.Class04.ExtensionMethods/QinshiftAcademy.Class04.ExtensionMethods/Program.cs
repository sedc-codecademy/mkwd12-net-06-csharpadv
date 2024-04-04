using QinshiftAcademy.Class04.ExtensionMethods;

string message = "C# Advanced is a hard subject, but it is what it is";

//List<string> words = StringHelper.TakeFirstWords(message, 3);
List<string> words = message.TakeFirstWords(3);
foreach (string word in words)
{
    Console.WriteLine(word);
}

List<int> ints = new List<int> { 4, 6, 8, 9 };
//ListHelper.PrintAll(ints);
ints.PrintAll();