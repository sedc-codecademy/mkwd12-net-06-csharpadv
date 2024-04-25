using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class11.Service
{
    public class ReaderWriter
    {
        public string ReadFile(string path)
        {
            string result = "";
            if (!File.Exists(path))
            {
                return "File does not exist!";
            }
            using(StreamReader sr = new StreamReader(path, true))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Succesfully read a file!");
            return result;
        }

        public void WriteFile(string path, string data)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfuly wirtten a file!");
        }
    }
}
