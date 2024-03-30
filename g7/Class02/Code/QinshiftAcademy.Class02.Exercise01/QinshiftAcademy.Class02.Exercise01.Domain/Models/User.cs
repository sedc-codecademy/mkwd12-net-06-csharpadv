using QinshiftAcademy.Class02.Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.Exercise01.Domain.Models
{
    public abstract class User : IUser
    {
        protected int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, string userName, string password)
        {
            //todo validation
            Id = new Random().Next(1, 1000000);
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }
        public abstract void PrintUser();
    }
}
