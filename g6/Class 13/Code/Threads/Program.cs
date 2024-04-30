//synchronous

void PrintMessagesSynchronous()
{
    Console.WriteLine("Hello");
    Console.WriteLine("First message"); //call to api/call to service
    Thread.Sleep(3000); //wait for response (wait 3s here)
    Console.WriteLine("Second message"); //validate the response
    Console.WriteLine("Third message"); //use the response
    Console.WriteLine("Bye");
}

//PrintMessagesSynchronous();

void PrintMessagesInDifferentThreads()
{
    Console.WriteLine("Hello");  //this is the only line that we know will execute first

    //we don't know the order in which the next lines of code will be executed

    Thread firstThread = new Thread(() =>
    {
        //Thread.Sleep(1000);
        Console.WriteLine("First message");
    });

    //we need to start the thread
    firstThread.Start();

    Thread secondThread = new Thread(() =>
    {
       // Thread.Sleep(1000);
        Console.WriteLine("Second message");
    });

    //we need to start the thread
    secondThread.Start();

    Console.WriteLine("Bye");
}

PrintMessagesInDifferentThreads();