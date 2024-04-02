using AbstractClassesAndInterface.Domain.Interfaces;

namespace AbstractClassesAndInterface.Domain.Models
{
    public class QAEngineer : Person, IQAEngineer, IDeveloper
    {
        public int NumberofProjects { get; set; }

        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(string fullName, int age,
            string address, long phoneNumber, int numOfProjects, List<string> testingFrameworks)
            :base(fullName, age, address, phoneNumber)
        {
            NumberofProjects = numOfProjects;
            TestingFrameworks = testingFrameworks != null ? testingFrameworks : new List<string>();
        }
        public override string GetProfessionalInfo()
        {
            string info = $"{FullName} works on {NumberofProjects} projects ";
            if(TestingFrameworks.Count > 0)
            {
                info += $"{FullName} knows the following frameworks: ";
                foreach(string framework in TestingFrameworks)
                {
                    info += $"{framework} \n";
                }
            }
            return info ;
        }

        public void TestingFeature(string feature, DateTime deadline)
        {
            Console.WriteLine($"Testing feature {feature}. The deadline is {deadline}");
        }

        public void Code()
        {
            Console.WriteLine($"{FullName} is a QA Engineer, but also works with writing code for testing");
        }
    }
}
