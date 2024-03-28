namespace AbstractAndInterface.Entities.Models.BaseModel
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }

        public Human(string firstName, string lastName, int age, long phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        public string GetInfo() 
        {
            return $"{GetFullName()} ({Age})";
        }
        public string GetFullName() 
        {
            return $"{FirstName} {LastName}";
        }
    }
}
