using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        //There should be a validation on first name and lastname to not be shorter than 2 characters
        public static bool ValidateName(string name)
        {
            if(string.IsNullOrEmpty(name) || name.Length < 2)
            {
                return false;
            }

            return true;
        }

        //Username should not be shorter than 6 characters

        public static bool ValidateUsername(string username)
        {
            if(string.IsNullOrEmpty(username) || username.Length < 6) {
                 return false;
            }

            return true;
        }
        //Password should not be shorter than 6 characters and should contain at least 1 number
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                return false;
            }

          //  if(password.Contains("0") || password.Contains("1") || password.Contains("2") || password.Contains("3"))

            foreach(char c in password)
            {
                bool isParsed = int.TryParse(c.ToString(), out int number);
                if (isParsed)
                {
                    return true;
                }

                //bool isDigit = Char.IsDigit(c);
                //if (isDigit)
                //{
                //    return true;
                //}
            }

            return false;
        }

        public static bool ValidateTrainingDuration (double duration)
        {
            if(duration < 10)
            {
                return false;
            }
            return true;
        }
    }
}
