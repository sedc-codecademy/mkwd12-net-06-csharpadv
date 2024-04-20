namespace MemoryAllocation
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User()
        {
            
        }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;       
        }

        public void PrintInfo()
        {
            Console.WriteLine($"INFO: {FirstName} {LastName} ({Age})");
        }
    }
}
