using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    //this class will also be abstract since it doesn't provide implementation for the abstract methods
    public abstract class Sales : Person
    {
        public Sales(string firstName, string lastName, long phoneNumber, string address) : 
            base(firstName, lastName, phoneNumber, address)
        {

        }
    }
}
