using AbstractClassesAndInterface.Domain.Interfaces;

namespace AbstractClassesAndInterface.Domain.Models
{
    public class DevOpsEngineer : Person, IDevOpsEngineer, IDeveloper
    {
        public bool IsAzureCertificated { get; set; }
        public bool IsAWSCertificated { get; set; }

        public DevOpsEngineer(string fullName, int age, string address, long phoneNumer, 
            bool isAzureCertificated, bool isAWSCertificated) : base(fullName, age, address, phoneNumer)
        {
            IsAzureCertificated = isAzureCertificated;
            IsAWSCertificated = isAWSCertificated;
        }

        public override string GetProfessionalInfo()
        {
            string info = $"{FullName}";
            info += IsAzureCertificated ? " has Azure cerificate. " : " does not have an Azure certificate";
            info += IsAWSCertificated ? " has AWS cerificate " : " does not have an AWS certificate ";
            return info ;
        }

        public bool CheckInfrastucture(int status)
        {
            List<int> okStatuses = new List<int> { 200, 202, 204 };
            return okStatuses.Contains(status); 
        }

        //each class can implement the methods differently, depending on the logic in that class
        public void Code()
        {
            if (IsAzureCertificated)
            {
                Console.WriteLine("Writing code for Azure portal service");
            }

            if (IsAWSCertificated)
            {
                Console.WriteLine("Writing code for AWS Portal services");
            }
        }
    }
}
