namespace Models
{
    public class User : BaseClass
    {
        public User(string name, string username, string idNumber, string createdBy) : base(createdBy)
        {
            Name = name;
            Username = username;
            IdNumber = idNumber;
        }

        public string Name { get; set; }
        public string Username { get; set; }
        public string IdNumber { get; set; }
    }
}
