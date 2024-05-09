namespace Class14.Examples.GoodPractices
{
    //bad example
    public class user
    {
        private readonly string userspath = @"C:\users";
        public int Id;
        public string name;
        public bool logged;
        public void printuser()
        {
            //...code
        }
        public void changeid(int NewId)
        {

        }
    }

    //good example
    public class  UserGood 
    {
        private readonly string _userPath = @"C:\users";
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLoggedIn { get; set; }
        public void PrintUser()
        {
            // ..code
        }

        public void ChangeId(int newId)
        {
            Id = newId;
        }
    }
}
