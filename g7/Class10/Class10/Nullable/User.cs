namespace Nullable
{
    public class User
    {
        // required
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }

        //optional
        //old way
        public Nullable<long> PID { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<bool> IsActive { get; set; }

        // nullable new way
        // ? after the type
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateOfBirthNotNull { get; set; }
    }
}
