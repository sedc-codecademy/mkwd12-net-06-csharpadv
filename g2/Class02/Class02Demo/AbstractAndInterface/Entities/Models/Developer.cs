using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class Developer : Human
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public long Phone {  get; set; }    
        //public string GetInfo() { }
        //public string GetFullName() { }
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }

        public Developer(string firstName, string lastName, int age, long phone, List<string> programmingLanguages, int yearsOfExperience) : base(firstName, lastName, age, phone)
        {
            ProgrammingLanguages = programmingLanguages;
            YearsOfExperience = yearsOfExperience;
        }
    }
}
