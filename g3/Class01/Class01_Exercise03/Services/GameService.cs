using Models;

namespace Services
{
    public class GameService
    {
        public OptionEnum GetRandomOption()
        {
            Random random = new Random();
            int number = random.Next(1, 4);

            return (OptionEnum)number;
        }

        public OptionEnum ParseOption(string input)
        {
            if (!int.TryParse(input, out int number))
            {
                throw new Exception("The input is not a number");
            }

            if (number < (int)OptionEnum.Rock || number > (int)OptionEnum.Scissors)
            {
                throw new Exception("The input is out of range");
            }

            return (OptionEnum)number;
        }

        public string GetStats(List<Game> games, Player player1, Player player2)
        {
            List<Game> gamesFiltered = games.Where(x => (x.Player1.Name == player1.Name && x.Player2.Name == player2.Name) ||
                                                        (x.Player1.Name == player2.Name && x.Player2.Name == player1.Name))
                                            .ToList();

            int totalGames = gamesFiltered.Count();
            int player1Wins = gamesFiltered.Where(x => x.GetWinner() != null && x.GetWinner().Name == player1.Name).Count();
            int player2Wins = gamesFiltered.Where(x => x.GetWinner() != null && x.GetWinner().Name == player2.Name).Count();
            int draws = totalGames - player1Wins - player2Wins;

            return $"Stats:\n{player1.Name} wins: {player1Wins}\n{player2.Name} wins: {player2Wins}\nDraws: {draws}\n" +
                $"Percentage:\n{player1.Name} wins: {player1Wins / (float)totalGames:P}\n{player2.Name} wins: {player2Wins / (float)totalGames:P}\nDraws: {draws / (float)totalGames:P}";

        }
    }
}
