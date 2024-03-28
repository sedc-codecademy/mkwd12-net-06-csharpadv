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
    }
}
