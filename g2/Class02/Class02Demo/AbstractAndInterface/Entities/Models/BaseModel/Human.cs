namespace AbstractAndInterface.Entities.Models.BaseModel
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        //public abstract string Test {  get; set; } // rarely used

        public Human(string firstName, string lastName, int age, long phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        public abstract string GetInfo();

        public string GetFullName() 
        {
            return $"{FirstName} {LastName}";
        }
    }
}
