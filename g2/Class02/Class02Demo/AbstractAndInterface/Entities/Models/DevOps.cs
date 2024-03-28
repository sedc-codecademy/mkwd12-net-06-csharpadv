using AbstractAndInterface.Entities.Models.BaseModel;

namespace AbstractAndInterface.Entities.Models
{
    public class DevOps : Human
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
    }
}
