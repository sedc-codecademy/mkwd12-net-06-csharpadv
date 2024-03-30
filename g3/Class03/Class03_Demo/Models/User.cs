namespace Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        //private string Password { get; set; }
        public string Password { get; private set; }
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}
        public string FullName => $"{FirstName} {LastName}";

        protected User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            SetPassword(password);
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password is required");
            }

            if (password.Length < 8)
            {
                throw new Exception("Password length should be at least 8");
            }

            Password = password;
        }

        public virtual string GetData()
        {
            return $"{FullName} ({Username})";
        }
    }
}
