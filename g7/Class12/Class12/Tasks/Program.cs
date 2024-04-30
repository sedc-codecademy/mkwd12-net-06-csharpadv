Console.WriteLine("app starts...");
Console.WriteLine("waiting for 2 seconds");
Thread.Sleep(2000);
// single task example
Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000ms");
});

myTask.Start();

Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("we can now get the number");
    return 6;
});
valueTask.Start();

Task.Run(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("This is executed immedietly...");
});
Console.WriteLine(valueTask.Result);
Console.WriteLine("App end");

for(int i = 0; i < 20; i++)
{
    int temp = i;
    Task.Run(() => {
        Thread.Sleep(2000);
        Console.WriteLine($"Task No. {temp}");
    });
};

Console.ReadLine();