using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : BaseEntity
    {
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpiryDate { get; set; }
        public string Model { get; set; }
        public Dictionary<ShiftEnum, Driver> Drivers { get; set; }

        public ValidityStatusEnum LicensePlateStatus
        {
            get
            {
                if (LicensePlateExpiryDate == new DateTime()) return ValidityStatusEnum.Red;
                else if (LicensePlateExpiryDate < DateTime.Today) return ValidityStatusEnum.Red;
                else if (LicensePlateExpiryDate > DateTime.Today && LicensePlateExpiryDate <= DateTime.Today.AddMonths(3)) return ValidityStatusEnum.Yellow;
                else if (LicensePlateExpiryDate > DateTime.Today.AddMonths(3)) return ValidityStatusEnum.Green;
                else return ValidityStatusEnum.Red;
            }
        }

        public Car(int id, string licensePlate, DateTime licensePlateExpriyDate, string model) : base(id)
        {
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = licensePlateExpriyDate;
            Model = model;
            Drivers = new Dictionary<ShiftEnum, Driver>();
        }

        public void ExtendLicensePlateExpiryDate()
        {
            LicensePlateExpiryDate = LicensePlateExpiryDate.AddMonths(6);
        }
    }
}
