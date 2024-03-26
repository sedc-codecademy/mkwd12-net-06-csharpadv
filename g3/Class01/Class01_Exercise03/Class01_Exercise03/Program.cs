using Models;
using Services;

namespace Class01_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool infiniteLoop = true;
            Player player1 = new Player("Risto");
            Player player2 = new Player("CPU");

            List<Game> games = new List<Game>();

            GameService service = new GameService();

            while (infiniteLoop)
            {
                Console.WriteLine("Please choose one of the options:\n1.) Play\n2.) Stats\n3.) Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("You have decided to play, great. Choose your option:\n1.) Rock\n2.) Paper\n3.) Scissors");
                                OptionEnum userOption = service.ParseOption(Console.ReadLine());
                                OptionEnum computerOption = service.GetRandomOption();

                                Game game = new Game(player1, userOption, player2, computerOption);
                                Console.WriteLine(game.GetInfo());

                                games.Add(game);

                                Player winner = game.GetWinner();

                                if (winner == null)
                                {
                                    Console.WriteLine("---------Draw---------");
                                }
                                else
                                {
                                    Console.WriteLine($"---------Winner: {winner.Name}---------");
                                }

                                Console.ReadLine();
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error happend: {ex.Message}\nTry again!");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine(service.GetStats(games, player1, player2));
                        Console.ReadLine();
                        break;
                    case "3":
                        infiniteLoop = false;
                        Console.WriteLine("Thank you for playing");
                        break;
                    default:
                        Console.WriteLine("Wrong input, please try again!");
                        break;
                }
            }
        }
    }
}
