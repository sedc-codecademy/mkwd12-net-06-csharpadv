using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPractices.Practices
{
    public class Loops
    {
        List<string> names = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne" };
        public void LoopsExample()
        {
            //Bad example
            //print all names that are the same length as the list
            for(int i = 0; i< names.Count; i++)
            {
                if (names[i].Length == names.Count)
                {
                    Console.WriteLine(names[i]);
                }
            }

            //Good example
            //print all names that are the same length as the list
            int listLength = names.Count;
            for (int i = 0; i < listLength; i++)
            {
                if (names[i].Length == listLength)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
