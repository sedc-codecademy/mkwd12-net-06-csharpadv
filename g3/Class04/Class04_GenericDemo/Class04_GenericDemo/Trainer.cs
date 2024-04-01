using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Class04_GenericDemo
{
    public class Trainer : User
    {
        public string Phone { get; set; }

        public Trainer(string firstName, string lastName, string phone) : base(firstName, lastName)
        {
            Phone = phone;
        }
    }
}
