using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FootballPlayer : User
    {
        public string StrongerFoot { get; set; }

        public FootballPlayer(string firstName, string lastName, string username, string password, string strongerFoot)
            : base(firstName, lastName, username, password)
        {
            StrongerFoot = strongerFoot;
        }

        public override string GetData()
        {
            return base.GetData() + $", Stronger foot: {StrongerFoot}";
        }
    }
}
