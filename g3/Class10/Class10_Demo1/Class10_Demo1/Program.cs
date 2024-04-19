namespace Class10_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a;
            string? text;
            text = null;
            bool? success;
            success = null;

            ConsoleColor? c;
            c = null;

            PrintMessage("Risto", 1);
            PrintMessage("Risto", 2, ConsoleColor.Green, ConsoleColor.Magenta);
            PrintMessage("Risto", 2, backgroundColor: ConsoleColor.Magenta);
            PrintMessage(backgroundColor: ConsoleColor.Magenta, lineNumber: 2, message: "Risto");
        }

        static void PrintMessage(string message, int lineNumber, 
            ConsoleColor color = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine($"{lineNumber}. {message}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
