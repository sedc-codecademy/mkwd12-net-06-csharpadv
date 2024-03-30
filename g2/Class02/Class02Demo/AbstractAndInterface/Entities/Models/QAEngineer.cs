using AbstractAndInterface.Entities.Interfaces;
using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class QAEngineer : Human, IDeveloper, ITester
    {
        public List<string> TestingFrameworks { get; set; } = new List<string>();

        public QAEngineer(string firstName, string lastName, int age, long phone, List<string> frameworks) : base(firstName, lastName, age, phone)
        {
            TestingFrameworks = frameworks;
        }

        public override string GetInfo()
        {
            string testingFrameworks = TestingFrameworks.Count != 0 ? string.Join(", ", TestingFrameworks) : "N/A";

            return $"{GetFullName()} ({Age}) - Knows testing frameworks: {testingFrameworks}.";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Open StackExchange SQA...");
            Console.WriteLine("tak tak tak tak...");
        }

        public void TestFeature(string featureName)
        {
            Console.WriteLine("Run Unit Tests...");
            Console.WriteLine("Run Automated Tests...");
            Console.WriteLine($"Tests for the {featureName} feature are done!");
        }
    }
}
