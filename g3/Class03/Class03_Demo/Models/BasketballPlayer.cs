using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BasketballPlayer : User
    {
        public int Height { get; set; }

        public BasketballPlayer(string firstName, string lastName, string username, string password, int height) 
            : base(firstName, lastName, username, password)
        {
            Height = height;
        }
    }
}
