using Models;

namespace Class03_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer p1 = new FootballPlayer("Erling", "Haland", "eric", "asdsad234", "left");
            BasketballPlayer p2 = new BasketballPlayer("Lebron", "James", "lebron", "Lebron123", 206);

            Console.WriteLine(p1.GetData());
            Console.WriteLine(p2.GetData());

            p1.SetPassword("asdsadasdasd");

            Console.WriteLine(PlayerHelper.GetStats(p1));
            Console.WriteLine(PlayerHelper.GetStats(p2));
            Console.WriteLine(PlayerHelper.GetStats(p1, 3));
        }
    }
}
