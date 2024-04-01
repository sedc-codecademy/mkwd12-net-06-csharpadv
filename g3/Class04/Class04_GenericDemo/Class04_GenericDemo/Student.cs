using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_GenericDemo
{
    public class Student : User
    {
        public string Email { get; set; }

        public Student(string firstName, string lastName, string email) : base(firstName, lastName)
        {
            Email = email;
        }
    }
}
