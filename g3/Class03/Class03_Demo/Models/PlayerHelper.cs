namespace Models
{
    public static class PlayerHelper
    {
        public static string GetStats(FootballPlayer p)
        {
            return $"For this football player:\n{p.GetData()}\nMark: 9.3";
        }
        //public static decimal GetStats(FootballPlayer p)
        //{
        //    return 2M;
        //}
        public static string GetStats(BasketballPlayer p)
        {
            return $"For this basketball player:\n{p.GetData()}\nMark: 8.0";
        }
        public static string GetStats(User u, decimal mark)
        {
            return $"For this player:\n{u.GetData()}\nMark: {mark}";
        }
    }
}
