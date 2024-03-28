using AbstractAndInterface.Entities.Interfaces;
using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class DevOps : Human, IOperations
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps(string firstName, string lastName, int age, long phone, bool awsCertified, bool azureCertified) : base(firstName, lastName, age, phone)
        {
            AWSCertified = awsCertified;
            AzureCertified = azureCertified;
        }

        public override string GetInfo()
        {
            string result = $"{GetFullName()} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certified" : "";
            result += AzureCertified ? "Azure Certified" : string.Empty; // string.Empty is the same as "", it is used for better readability
            result += AWSCertified || AzureCertified ? string.Empty : "No certificates yet";
            return result;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new() { 200, 202, 204 };
            //List<int> okStatuses = new List<int>() { 200, 202, 204 }; // same thing
            return okStatuses.Contains(status); // Contains => returns boolean
            //if (okStatuses.Contains(status))
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
