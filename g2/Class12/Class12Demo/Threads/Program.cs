Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n============== THREADS ==============\n\n");
Console.ResetColor();
// Thread is a path of execution within a process
// They are the smallest unit of execution that can be scheduled by an operating system
// They allow a program to perform multiple tasks concurrently (at same time)

#region Method
// Synchronous
void SendMessages()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(2000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Third message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("All messages are recived!");
    Console.ReadLine();
}

// Asynchronous
void SendMessagesWithThreads()
{
    Console.WriteLine("Getting ready...");

    Thread myThread = new Thread(() =>
    {
        Thread.Sleep(5000);
        Console.WriteLine("First message arrived!");
    });
    myThread.Start();

    new Thread(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine("Second message arrived!");
    }).Start();

    new Thread(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Third message arrived!");
    }).Start();

    Console.WriteLine("All messages are recived!");
    Console.ReadLine();
}

#endregion

// ===> Synchronous execution
//SendMessages();

// ===> Asynchronous execution
SendMessagesWithThreads();
