using System.Globalization;

namespace GoodPractices.Practices
{
    //Bad Example
    public class user
    {
        private string userpath;
        public int id;
        public string name;
        public bool logged;

        public void printuser()
        {
            //code
        }

        public void changeId(int NewID)
        {
            id = NewID;
        }
    }

    //Good Example
    public class User
    {
        private string _userPath; //for private properties we use _
        public int Id; //we should to use PascalCase
        public string Name;
        public bool IsLoggedIn; //we tend to name the boolean properties as short questions

        public void PrintUser() //we should to use PascalCase
        {
            //code
        }

        public void ChangeId(int newId) //we tend to use PascalCase for naming the method and camelCase for naming the params
        {
            Id = newId;
        }
    }

    //Exceptions
    //Bad example

    class LoginProblem : Exception
    {
        //code
    }

    //Good example
    class LoginException : Exception
    {
        //code
    }
}
