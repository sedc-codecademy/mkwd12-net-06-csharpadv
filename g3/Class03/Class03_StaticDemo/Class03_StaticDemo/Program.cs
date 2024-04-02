namespace Class03_StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your domain name:");
            string input = Console.ReadLine();
            
            string username = DomainNameHelper.GetUserName(input);
            string fullName = DomainNameHelper.GetFullName(input);

            Console.WriteLine(username);
            Console.WriteLine(fullName);

            var manCity = new FootballTeam("Man. City", new List<string> { "W", "W", "D", "L", "W", "W" });
            var arsenal = new FootballTeam("Arsenal", new List<string> { "W", "W", "D", "W", "W", "W" });

            manCity.AddDraw();
            arsenal.AddWin();

            int manCityPoints = FootballTeam.GetTeamPoints(manCity);
            int arsenalPoints = FootballTeam.GetTeamPoints(arsenal);

            Console.WriteLine($"{manCity.Name}: {manCityPoints}");
            Console.WriteLine($"{arsenal.Name}: {arsenalPoints}");
        }
    }
}
