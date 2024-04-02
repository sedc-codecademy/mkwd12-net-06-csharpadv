namespace Class03_StaticDemo
{
    public static class DomainNameHelper
    {
        //SEDC\risto.panchevski
        public static string GetUserName(string fullUserName)
        {
            return fullUserName.Replace("SEDC\\", "");
        }

        public static string GetFullName(string fullUserName)
        {
            return GetUserName(fullUserName).Replace(".", " ");
        }
    }
}
