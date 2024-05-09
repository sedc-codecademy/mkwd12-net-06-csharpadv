//it must return a Task, Task<int>, Task<Student>...
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending a message..."); //part of main thread

    //the code in the task is sent away to be executed on another thread
    //the code on line 15 won't be executed until the task finishes (at least 5s)
    //because the code n the task is sent away, at that moment the main thread is free
    await Task.Run(() => //we use the away keyword to specify if we would like the app to wait for the task to finish before continuing or not
    {
        Thread.Sleep(5000); //simulate an operation that lasts at least 5s
        Console.WriteLine("Message: " + message);
    });

    Console.WriteLine("The message was sent"); //part of main thread
}

void ShowAd(string product)
{
    Console.WriteLine("While you are waiting for the message to be sent, let us show you an ad");
    Console.WriteLine($"You can have this product {product} in the next 10 min..");
}

//because there is code that is awaited in this method (the second console write (the message was sent waits for the task to finish)
//our main thread is free and that means that ShowAd can be executed
SendMessageAsync("Hello G6");
ShowAd("milk");

//if you want the whole code on the main thread to wait for the awaited code, we put await in front of the call of SendMessageAsync 
//await SendMessageAsync("Hello G6");
//ShowAd("milk"); //this line won't be executed until the method SendMessageAsync has finished

Console.ReadLine();