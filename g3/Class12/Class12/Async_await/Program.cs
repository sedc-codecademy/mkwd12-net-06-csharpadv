async Task MainThread()
{
    await SendMessageAsync("Hey there students from Qinshift academy!");
    ShowAd("Potato");
    Thread.Sleep(2500);
    var number = await GetSomeRandomNumber();
    number = number + 500;
    Console.WriteLine(number);
    await SendMessageAsync("Hey there students from Qinshift academy!");
    ShowAd("Popcorn");
}

//this is sync method
void SendMessage(string message)
{
    Console.WriteLine("Sending message;");
    Thread.Sleep(7000);
    Console.WriteLine($"The message {message} was send");
}

//this is async method
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message;");
    await Task.Run(() =>
    {
        Thread.Sleep(7000);
        Console.WriteLine($"The message {message} was send");
    });
}

async Task<int> GetSomeRandomNumber()
{
    Thread.Sleep(1500);
    Random rnd = new Random();
    int a = rnd.Next(1, 100);
    Console.WriteLine(a);
    return a;
}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad");
    Console.WriteLine("Buy the best product in the world");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(product);
    Console.ResetColor();
    Console.WriteLine("now and get");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("FREE");
    Console.ResetColor();
    Console.WriteLine("shipping worldwide");

}

//var x = SendMessageAsync("Hey there students from Qinshift academy!");
//Console.WriteLine($"The status of the async method is {x.Status}");

MainThread();
Console.ReadLine();