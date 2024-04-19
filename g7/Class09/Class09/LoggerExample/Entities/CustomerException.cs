namespace LoggerExample.Entities
{
    public class InvalidUserPropertyException : Exception
    {
        private LoggerService _logger = new LoggerService();
        public string BrokenProperty { get; set; }
        public string BrokenValue { get; set; }
        public string BrokenUser { get; set; }
        public InvalidUserPropertyException() : base("Unknown user had an invalid value matching some of it's properties!")
        {
            _logger.LogError();
        }
        public InvalidUserPropertyException(string property, string value, string username) : base($"A problem occured with {property} property when adding a value {value}!")
        {
            BrokenProperty = property;
            BrokenValue = value;
            BrokenUser = username;
            _logger.LogError();
        }
    }

    public class InvalidLoginException : Exception
    {
        private LoggerService _logger = new LoggerService();
        public string Username { get; set; }
        public InvalidLoginException(string username) : base("User entered wrong username or password!")
        {
            Username = username;
            _logger.LogError();
        }
    }
}