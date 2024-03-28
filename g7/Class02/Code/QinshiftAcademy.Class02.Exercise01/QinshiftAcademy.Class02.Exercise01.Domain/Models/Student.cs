using QinshiftAcademy.Class02.Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.Exercise01.Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(string firstName, string lastName, string userName, string password, List<int> grades)
            : base(firstName, lastName, userName, password)
        {
            Grades = grades != null ? grades : new List<int>();
        }

        //from the abstract class
        public override void PrintUser()
        {
            Console.WriteLine($"Student {FirstName} {LastName} has the following grades:");
            foreach (int grade in Grades)
            {
                Console.Write($"{grade} ");

            }

            Console.WriteLine();
        }

        //from the interface
        public double GetAverageGrade()
        {
            int sum = 0;

            foreach (int grade in Grades)
            {
                sum += grade;
            }

            //we cast the value of the variable sum to double, which means we say that it's type
            //should be seen as double in this case
            //we do this to avoid division of two integers
            return Grades.Count > 0 ? (double)sum / Grades.Count : 0;
        }
    }
}
