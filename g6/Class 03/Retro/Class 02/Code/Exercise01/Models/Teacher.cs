using Exercise01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string username, string password, string subject)
            :base(id, name, username, password)
        {
            Subject = subject;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher with id {Id} and name: {Name} and username: {Username} teaches {Subject}");
        }

        public void PrintSubjects()
        {
            Console.WriteLine($"{Username} teaches {Subject}");
        }
    }
}
