namespace Models
{
    public class Game
    {
        public Player Player1 { get; set; }
        public OptionEnum Player1Choice { get; set; }
        public Player Player2 { get; set; }
        public OptionEnum Player2Choice { get; set; }

        public Game(Player player1, OptionEnum player1Choice, Player player2, OptionEnum player2Choice)
        {
            Player1 = player1;
            Player1Choice = player1Choice;
            Player2 = player2;
            Player2Choice = player2Choice;
        }


        public Player GetWinner()
        {
            if ((Player1Choice == OptionEnum.Rock && Player2Choice == OptionEnum.Scissors) ||
                (Player1Choice == OptionEnum.Scissors && Player2Choice == OptionEnum.Paper) ||
                (Player1Choice == OptionEnum.Paper && Player2Choice == OptionEnum.Rock))
            {
                return Player1;
            }

            if ((Player2Choice == OptionEnum.Rock && Player1Choice == OptionEnum.Scissors) ||
                (Player2Choice == OptionEnum.Scissors && Player1Choice == OptionEnum.Paper) ||
                (Player2Choice == OptionEnum.Paper && Player1Choice == OptionEnum.Rock))
            {
                return Player2;
            }

            return null;
        }

        public string GetInfo()
        {
            return $"{Player1.Name} => {Player1Choice}\n{Player2.Name} => {Player2Choice}";
        }
    }
}
