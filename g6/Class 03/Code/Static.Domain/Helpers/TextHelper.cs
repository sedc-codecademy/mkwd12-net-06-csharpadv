using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Domain.Helpers
{
    public static class TextHelper
    {
        //title => Title
        public static string ToCapitalFirstLetter(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty; //""
            }else if(word.Length == 1) {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                //sedc => Sedc
                //we can also use the index or to charArray, this is not the only way
                //here we take the substring starting index 0 and 1 character after (the first letter) and then second substring to get all remaining letter starting from 1
                return word.Substring(0,1).ToUpper() + word.Substring(1);
            }
        }

        public static int ValidateInput(string input)
        {
            int choice = 0;
            bool success = int.TryParse(input, out choice);
            if (success)
            {
                return choice;
            }
            else
            {
                return -1;
            }
        }
    }
}
