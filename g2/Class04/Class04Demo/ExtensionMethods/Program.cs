using ExtensionMethods.Helpers;
using ExtensionMethods.Models;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n=================== EXTENSION METHODS ===================\n");
Console.ResetColor();


#region String Extensions
Console.WriteLine("\n============== String Extensions ==============\n");

string text = "C# Advanced is an awesome subject with great demos and activities";
string shortenText = StringExtensions.Shorten(text, 5);
Console.WriteLine(shortenText);
Console.WriteLine(text.Shorten(4));
Console.WriteLine("Vazi za sekoj string".Shorten(3));

string text2 = "Hello from G2";
Console.WriteLine(text2.QuoteString());

#endregion


#region List Extensions
Console.WriteLine("\n============== List Extensions ==============\n");

List<string> strings = new() { "Bob", "Nostradamus", "Ryan Gosling" };
//foreach (string s in strings)
//{
//    Console.WriteLine(s);
//}
//strings.GoThrough();
strings.NasaMetoda();

Console.WriteLine(strings.ToCommaSeparatedString());

#endregion


#region Product Extensions
Console.WriteLine("\n============== Product Extensions ==============\n");

Product product = new Product(1, "Samsung Universe 9", "Samsungs new variant which goes beyond Galaxy to the Universe");

product.PrintProductInfo();
#endregion


Console.ReadLine();