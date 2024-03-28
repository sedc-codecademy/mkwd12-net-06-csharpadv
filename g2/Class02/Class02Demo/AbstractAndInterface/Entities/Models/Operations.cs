using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class Operations : Human
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(string firstName, string lastName, int age, long phone, List<string> projects) : base(firstName, lastName, age, phone)
        {
            Projects = projects;
        }
    }
}
