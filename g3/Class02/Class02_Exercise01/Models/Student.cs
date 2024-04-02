
namespace Models
{
    //public class Student : IStudent
    //{
    //    //public List<int> Grades { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public List<int> Grades { get; set; }

    //    public Student(List<int> grades)
    //    {
    //        Grades = grades;
    //    }

    //    public string GetUser()
    //    {
    //        return string.Join(", ", Grades);
    //    }
    //}

    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(string name, string username, string password, List<int> grades) : base(name, username, password)
        {
            Grades = grades;
        }

        public override string GetUser()
        {
            var result = base.GetUser() + "\nGrades:\n" + string.Join(",", Grades);
            return result;
        }
    }
}
