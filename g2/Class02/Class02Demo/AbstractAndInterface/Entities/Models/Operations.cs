using AbstractAndInterface.Entities.Interfaces;
using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(string firstName, string lastName, int age, long phone, List<string> projects) : base(firstName, lastName, age, phone)
        {
            Projects = projects;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Currently working on {Projects.Count} projects!";
        }

        public bool CheckInfrastructure(int status)
        {
            return !status.ToString().StartsWith('4');
            if (status.ToString().StartsWith('4')) 
            {
                return false;
            }
            return true;
        }
    }
}
