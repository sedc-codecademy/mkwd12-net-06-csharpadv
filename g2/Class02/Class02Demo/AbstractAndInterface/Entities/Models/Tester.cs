using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class Tester : Human
    {
        public int BugsFound { get; set; }

        public Tester(string firstName, string lastName, int age, long phone, int bugsFound) : base(firstName, lastName, age, phone)
        {
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - found {BugsFound} bugs to date!";
        }
    }
}
