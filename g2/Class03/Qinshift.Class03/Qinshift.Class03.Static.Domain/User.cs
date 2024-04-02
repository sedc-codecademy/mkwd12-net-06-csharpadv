using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class03.Static.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Orders> Orders { get; set; }

        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Address = address;
            Orders = new List<Orders>();
        }

        public void PrintOrder()
        {
            for(int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i}) {Orders[i].Print()}");
            }
        }

    }
}
