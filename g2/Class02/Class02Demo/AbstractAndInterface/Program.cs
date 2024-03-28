using AbstractAndInterface.Entities.Models;
using AbstractAndInterface.Entities.Models.BaseModel;
using System.Globalization;


#region Creating instances

Developer dev = new Developer("Bob", "Bobsky", 30, 38978078078, new List<string> { "Javascript", "C#", "SQL" }, 5);

Tester tester = new Tester("Jill", "Wayne", 32, 38971071071, 500);

Operations ops = new Operations("Greg", "Gregsky", 28, 38975057057, new List<string> { "Optimus", "Devin", "PickPro" });

DevOps devOps = new DevOps("John", "Doe", 24, 38978123123, false, true);

QAEngineer qa = new QAEngineer("Steve", "Stevenson", 35, 38970057343, new List<string> { "Selenium", "Puppeteer" });

// Can't create an instance of an abstract class !!!
// Human human = new Human("test", "test", 23, 23432423);

#endregion

#region Testing all methods
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("The Developer:");
Console.WriteLine(dev.GetInfo());
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("The Tester:");
Console.WriteLine(tester.GetInfo());
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("The IT Operations Specialist:");
Console.WriteLine(ops.GetInfo());
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("The DevOps:");
Console.WriteLine(devOps.GetInfo());
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("The QA Engineer:");
Console.WriteLine(qa.GetInfo());
Console.ResetColor();

Console.WriteLine("----------------");

#endregion