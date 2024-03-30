using QinshiftAcademy.Class02.Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.Exercise01.Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public Teacher(string firstName, string lastName, string userName, string password, string subject) 
            : base(firstName, lastName, userName, password)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public void PrintSubject()
        {
            Console.WriteLine($"The current subject is {Subject}.");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName} teaches {Subject}");
        }
    }
}
