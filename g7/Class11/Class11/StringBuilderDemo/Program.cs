using System.Diagnostics;
using System.Text;

var data = Enumerable.Repeat("abcdefgh", 100_000);
Console.WriteLine(data.Count());
#region using string concatenation

Stopwatch stopwatch = Stopwatch.StartNew();

Console.WriteLine("using contatenation");
string result = string.Empty;
foreach (var word in data)
{
    result += word;
}

stopwatch.Stop();
Console.WriteLine(result.Length);
Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);

#endregion

#region using Stringbuilder

Console.WriteLine("Using string builder");
stopwatch = Stopwatch.StartNew();

var result2 = new StringBuilder();
foreach (var word in data)
{
    result2.Append(word);
}

stopwatch.Stop();
var stringResult = result2.ToString();
Console.WriteLine(stringResult.Length);
Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);

Console.ReadLine();

#endregion