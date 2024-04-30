using System.Runtime.CompilerServices;

Console.WriteLine("app stars...");
Console.WriteLine("2000");

//Single task example
Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("running after 2000ms");
    Console.WriteLine("info from task that doesnt return value");
});

myTask.Start();

//Task can return a value aswell
Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("we can now get the number");
    return 6;
});
valueTask.Start();
Console.WriteLine($"the value that is returned from the task named valueTask is:{valueTask.Result}");
Console.WriteLine("app ends");

Task.Run(() => {
    Thread.Sleep(3000);
    Console.WriteLine("This is executed .......");
});

for(int i = 0; i < 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine($"Task No. {temp}");
    });
}

Console.ReadLine();