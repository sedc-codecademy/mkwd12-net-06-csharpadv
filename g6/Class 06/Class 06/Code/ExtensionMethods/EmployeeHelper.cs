using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class EmployeeHelper
    {

        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address}");
        }

        public static void Print(this Employee employee, int salary)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address}");
        }

        public static void PrintNoParams(this Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address}");
        }
    }
}
