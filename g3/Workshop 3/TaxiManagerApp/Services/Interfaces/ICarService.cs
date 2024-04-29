using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICarService
    {
        void CreateCar(string licensePlate, DateTime licensePlateExpiryDate, string model);
    }
}
