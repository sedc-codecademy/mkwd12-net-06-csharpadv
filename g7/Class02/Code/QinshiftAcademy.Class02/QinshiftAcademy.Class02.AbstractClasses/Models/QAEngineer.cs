

using QinshiftAcademy.Class02.AbstractClasses.Interfaces;

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    public class QAEngineer : Person, IEngineer, IQAEngineer
    {
        public int NumberOfProjects { get; set; }
        public List<string> TestingFrameworks { get; set; }
        public QAEngineer(string firstName, string lastName, long phoneNumber, string address, int numOfProjects) 
            : base(firstName, lastName, phoneNumber, address)
        {
            NumberOfProjects = numOfProjects;
            TestingFrameworks = new List<string>
            {
                "Selenium"
            };
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"QA Engineer: {FirstName} {LastName} works on {NumberOfProjects} projects.");

            if (TestingFrameworks != null && TestingFrameworks.Count > 0)
            {
                Console.WriteLine($"{FirstName} {LastName} knows the following test frameworks:");
                foreach (string framework in TestingFrameworks)
                {
                    Console.WriteLine(framework);
                }
            }
        }

        public string GetEngineeringSchoolName()
        {
            return "QA School";
        }

        public void TestFeature(string feature, DateTime deadline)
        {
            Console.WriteLine($"The feature {feature} will have to be tested by {deadline}");
        }
    }
}
