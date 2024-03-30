using Exercise01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public abstract class User :IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password {  get; set; }

        public User(int id, string name,string username, string password)
        {
            Id = id;
            Name = name;
            Password = password;
            Username = username;
        }

        public void PrintUser()
        {
            Console.WriteLine($"User {Username} is {Name} with id: {Id}");
        }
    }
}
