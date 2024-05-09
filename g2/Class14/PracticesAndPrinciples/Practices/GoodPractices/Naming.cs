namespace Practices.GoodPractices
{
    /*
        *** NAMING GOOD PRACTICES ***

        0. Don't use space when naming solutions, projects, folders....anything. 

        1. Classes, Methods, Properties, Interfaces, public fields are written in PascalCase
        2. Variables and Parameters are always written in camelCase
        3. Private fields are always written with underscore camelCase ( ex: _privateField )

        4. Write Descriptive names !!!
     */

    #region CLASSES, PROPERTIES, FIELDS, METHODS

    // Bad Example
    internal class user
    {
        private readonly string usersFolder = @"C:\users";
        public int id;
        public string username;
        public string Password;



        public int age;
        public bool Logged { get; set; } = false;
        public List<string> HobbyList { get; set; }

        public void changeUsername(string Username)
        {
            this.username = Username;
        }
        public void changePwd(string pwd)
        {
            Password = pwd;
        }
        public async void GetUsers()
        {
            // code
        }
    }

    // Good Example

    #endregion


    #region ENUMS

    // Bad Example
    public enum RoleEnum
    {
        Admin,
        User
    }

    // Good Example
    
    #endregion


    #region INTERFACES

    // Bad Example
    public interface UserService
    {
        void PrintUser(string username)
        {
            // code ...
        }
    }

    // Good Example
    
    #endregion

}
