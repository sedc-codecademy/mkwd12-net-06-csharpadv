using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringHelper
    {
        public static string Shorten(this string text, int numOfWords)
        {
           if(numOfWords <= 0)
            {
                return "";
            }
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            string[] words = text.Split(" ");
            if(words.Length < numOfWords)
            {
                return text;
            }

            //Take returns IEnumerable and we can transform id toList or toArray...
            List<string> resultWords = words.Take(numOfWords).ToList();// Some, text, about
            
            string result = string.Join(" ", resultWords); //Some text about G6 and Qinshift Academy
            return result;
        }
    }
}
