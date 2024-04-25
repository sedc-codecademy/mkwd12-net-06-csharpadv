Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n============== ASYNC/AWAIT ==============\n\n");
Console.ResetColor();


#region Methods
// Synchronous method
void SendMessage(string message)
{
    Console.WriteLine("Sending message ...\n");
    Thread.Sleep(7000);
    Console.WriteLine(string.Format(@"The message ""{0}"" was sent!", message));
}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad:");
    Console.Write("Buy the best product in the world ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(product);
    Console.ResetColor();
    Console.Write(" now and get ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("FREE");
    Console.ResetColor();
    Console.WriteLine(" shipping worldwide!\n");
}

// Asynchronous method
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message ...\n");
    //Task.Run(() =>
    await Task.Run(() =>
    {
        Thread.Sleep(7000);
        Console.WriteLine($@"The message ""{message}"" was sent!");
    });
    Console.WriteLine("It takes just 7 seconds...");
}

async Task OurMainThread()
{
    await SendMessageAsync("Hello there Qinshift Academy students");
    //string product = GetAdvertismentItem(); // null
    string product = await GetAdvertismentItemAsync(); // Mouse => will await for the 'call' to finish
    ShowAd(product);
}

string GetAdvertismentItem()
{
    string result = null;
    Task.Run(() =>
    {
        // "call to db"
        Thread.Sleep(7000);
        result = "Mouse";
    });
    return result;
}

async Task<string> GetAdvertismentItemAsync()
{
    string result = null;
    await Task.Run(() =>
    {
        // "call to db"
        Thread.Sleep(7000);
        result = "Mouse";
    });
    return result;
}

#endregion

string message = "Hello there Qinshift Academy students";

// ===> Example for sync execution
//SendMessage(message);
//ShowAd("Laptop");

// ===> Example of async execution
//SendMessageAsync(message);
//ShowAd("Potato");

// ===> Example of sync execution of async operation
//await SendMessageAsync(message);
//ShowAd("Charger");

// ===> we can assign the task to a variable
//Task sendMessageTask = SendMessageAsync(message);
//Console.WriteLine(sendMessageTask.Status);
//ShowAd("Glasses");
//Console.ReadLine();
//Console.WriteLine(sendMessageTask.Status);


OurMainThread();


Console.WriteLine("\nEverything finished...\n");
Console.ReadLine();