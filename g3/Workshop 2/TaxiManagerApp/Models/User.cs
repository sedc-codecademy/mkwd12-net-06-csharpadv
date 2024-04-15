using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public RoleEnum Role { get; set; }

        public User(int id, string firstName, string lastName, string username, string password, RoleEnum role) 
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            //Password = password;
            SetPassword(password);
            Role = role;
        }

        public void SetPassword(string password)
        {
            if(string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password is required");
            }

            if(password.Length < 8)
            {
                throw new ArgumentException("Password length needs to be at least 8 chars");
            }

            Password = password;
        }


    }
}
