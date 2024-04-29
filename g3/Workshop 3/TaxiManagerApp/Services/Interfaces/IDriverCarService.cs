using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDriverCarService
    {
        void AssignDriverToCar(int driverId, int carId, int shift);
    }
}
