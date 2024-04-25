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

#endregion

string message = "Hello there Qinshift Academy students";

// ===> Example for sync execution
SendMessage(message);
ShowAd("Laptop");

Console.WriteLine("\nEverything finished...\n");
Console.ReadLine();