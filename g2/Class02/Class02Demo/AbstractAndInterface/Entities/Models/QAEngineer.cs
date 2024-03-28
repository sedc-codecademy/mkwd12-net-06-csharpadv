using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class QAEngineer : Human
    {
        public List<string> TestingFrameworks { get; set; } = new List<string>();

        public QAEngineer(string firstName, string lastName, int age, long phone, List<string> frameworks) : base(firstName, lastName, age, phone)
        {
            TestingFrameworks = frameworks;
        }
    }
}
