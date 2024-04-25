Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n============== TASKS ==============\n\n");
Console.ResetColor();


Console.WriteLine("App start...\n");

// ===> Single Task Example
//Task myTask = new Task(() =>
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Running after 2000ms");
//});
//myTask.Start();


// ===> Single task with return type example
//Task<int> valueTask = new Task<int>(() =>
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("We can now get the number...");
//    return 3;
//});
//valueTask.Start();
//Console.WriteLine(valueTask.Status);
//Console.WriteLine(valueTask.Result);


// ===> Creating Task directly on the Thread Pool
//Task.Run(() =>
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("This is executed immediately...");
//});



for (int i = 1; i < 21; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        Thread.Sleep(1500);
        Console.WriteLine($"TASK NO. {temp}");
    });
}


Console.WriteLine("\nApp end...\n");

Console.ReadLine();
