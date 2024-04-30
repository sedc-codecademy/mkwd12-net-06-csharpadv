//This was done on a syncronious way on a single thread
void SendMessages()
{
    Console.WriteLine("Getting Ready...");
    Thread.Sleep(2000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are recieved");
    Console.ReadLine();
}

//This is done on a async way with manually opening new threads and executing them at same time
//The behaviour you are observing while executing this code
//is due to the nature of multithreading
//when you start a new thread it runs concurrently with all other threads
//however, the exact order in which thread execute is not guaranteed and cana vary each time
//so we dont have total control of what will happen 1st, 2nd ...
void SendMessagesWithThreads()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(2000);
    Thread myThread = new Thread(() => { // 1st Thread
        Thread.Sleep(2000);
        Console.WriteLine("First message arrived!");
    });
    myThread.Start();
    new Thread(() => // 2nd thread
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second message arrived!");
    }).Start();
    new Thread(() => {
        Thread.Sleep(2000);
        Console.WriteLine("Third message arrived");
    }).Start();
    Console.WriteLine("All messagess are recieved");
    Console.ReadLine();
}

//SendMessages();
SendMessagesWithThreads();