using QinshiftAcademy.Class02.AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    public abstract class Engineer : IEngineer
    {
        public abstract string GetEngineeringSchoolName();
    }
}
