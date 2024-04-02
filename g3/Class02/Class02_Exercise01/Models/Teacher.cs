namespace Models
{
    public class Teacher : User
    {
        public string Subject { get; set; }

        public Teacher(string name, string username, string password, string subject) : base(name, username, password)
        {
            Subject = subject;
        }

        public override string GetUser()
        {
            return base.GetUser() + $", Subject: {Subject}";
        }
    }
}
