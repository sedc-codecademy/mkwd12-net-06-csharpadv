void SendMessages()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(2000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);
    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are recieved!");
    Console.ReadLine();
    //this was done on a single thread in a syncronious way
}

//The behaviour youre observing is due to to the nature of multithreading
//when you start anew thread, it runs concurrently with all other threads
//however, the exact order in which threads excecute is not guaranteed and can vary each time the program runs 

void SendMessagesWithThreads()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(2000);
    Thread myThread = new Thread(() => { // 1st thread
        Thread.Sleep(2000);
        Console.WriteLine("First message arrived!");
    });
    myThread.Start();
    new Thread(() => //second thread
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second message arrived!");
    }).Start();
    new Thread(() => // third thread
    {
        Thread.Sleep(2000);
        Console.WriteLine("Third message arrived!");
    }).Start();
    Console.WriteLine("All messages are recieved!");
    Console.ReadLine();
}

//SendMessages();
SendMessagesWithThreads(); // => order of messages will be different because of nanomilisecond difference