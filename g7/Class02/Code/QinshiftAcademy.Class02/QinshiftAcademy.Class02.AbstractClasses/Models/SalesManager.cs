using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    public class SalesManager : Sales
    {
        public double Salary { get; set; }
        public SalesManager(string firstName, string lastName, long phoneNumber, string address) 
            : base(firstName, lastName, phoneNumber, address)
        {
            Salary = 800;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Sales manager: {FirstName} {LastName}, salary basis : {Salary}");
        }
    }
}
