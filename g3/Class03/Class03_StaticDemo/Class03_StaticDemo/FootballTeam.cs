namespace Class03_StaticDemo
{
    public class FootballTeam
    {
        public string Name { get; set; }
        public List<string> Form { get; set; }

        public FootballTeam(string name, List<string> form)
        {
            Name = name;
            Form = form;
        }

        public void AddWin()
        {
            Form.Add("W");
        }

        public void AddLost()
        {
            Form.Add("L");
        }

        public void AddDraw()
        {
            Form.Add("D");
        }

        public static int GetTeamPoints(FootballTeam footballTeam)
        {
            int points = 0;

            foreach(var result in footballTeam.Form)
            {
                if (result == "W") points += 3;
                else if (result == "D") points += 1;
                //else if (result == "L") points += 0;
            }

            return points;
        }
    }
}
