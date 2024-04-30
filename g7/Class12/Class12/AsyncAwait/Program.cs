async Task MainThread() // => async keyword in method makes that method asyncronious
{
    //SendMessage("Hey There Students FROM QINSHIFT");
    await SendMessageAsync("Hey there Qinshift students!"); // data 1 => we AWAIT this data to be inished
    ShowAd("Potato"); // Here We somehow manipulate data 1 as we see fit for our needs
    await SendMessageAsync("Hey there Qinshift students!"); // We can again wait for some data 2
    ShowAd("Potato"); // Here after everything above finishes and we process all data, we call another method for finish
    Console.ReadLine();
}

//syncronious way
void SendMessage(string message)
{
    Console.WriteLine("Sending message...");
    Thread.Sleep(7000);
    Console.WriteLine($"The message {message} was send");
}

//asyncronoius way
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Run(() => {
        Thread.Sleep(7000);
        Console.WriteLine($"The message {message} was send");
    });
    //Console.ReadLine();
}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad:");
    Console.WriteLine("Buy the best product in the world");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(product);
    Console.ResetColor();
    Console.WriteLine("now and get");
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("FREE");
    Console.ResetColor();
    Console.WriteLine("shipping worldwide");
    //Console.ReadLine();
}

//Example for syncronious execution
//SendMessage("Hey There Students");

//example of asyncronious execution
//var x = SendMessageAsync("Hey There Dear students!");
//Console.WriteLine($" The status of the async method{x.Status}");

//ShowAd("Potato");
//Console.ReadLine();
//Console.WriteLine($" The status of the async method{x.Status}");
//Console.ReadLine();

MainThread();
Console.ReadLine();