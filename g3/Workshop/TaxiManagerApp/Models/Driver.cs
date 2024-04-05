using Models.Enums;

namespace Models
{
    public class Driver : User
    {
        public string DriverLicenseNumber { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public ValidityStatusEnum LicenseStatus
        {
            get
            {
                //if (LicenseExpiryDate == null) return ValidityStatusEnum.Red;
                if (LicenseExpiryDate == new DateTime()) return ValidityStatusEnum.Red;
                else if (LicenseExpiryDate < DateTime.Today) return ValidityStatusEnum.Red;
                else if (LicenseExpiryDate > DateTime.Today && LicenseExpiryDate <= DateTime.Today.AddMonths(3)) return ValidityStatusEnum.Yellow;
                else if (LicenseExpiryDate > DateTime.Today.AddMonths(3)) return ValidityStatusEnum.Green;
                else return ValidityStatusEnum.Red;
            }
        }


        public Driver(int id, string firstName, string lastName, string username, string password,
            string driverLicenseNumber, DateTime licenseExpiryDate)
            : base(id, firstName, lastName, username, password, RoleEnum.Driver)
        {
            DriverLicenseNumber = driverLicenseNumber;
            LicenseExpiryDate = licenseExpiryDate;
        }

        public void ExtendLicenseExpiryDate(DateTime newExpirationDate)
        {
            LicenseExpiryDate = newExpirationDate;
        }
    }
}
