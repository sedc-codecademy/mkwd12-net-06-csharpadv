namespace Class14.Examples.Principles
{
    //bad example
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public int Grade { get; set; }
        public bool HasProject { get; set; }
        public int Homeworks { get; set; }

        //initial implementation
        // the client has only one type of student, code student
        public bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "friday") return true;
            return false;

            //if (Academy == "Code")
            //{
            //    if (day == "monday" || day == "friday") return true;
            //    return false;
            //}
            ////after we add more students =>
            //else if (Academy == "Design")
            //{
            //    if (day == "monday" || day == "wednesday" || day == "friday") return true;
            //    return false;
            //}
            //else if (Academy == "Network")
            //{
            //    if (day == "monday" || day == "thursday" day == "friday") return true;
            //    return false;
            //}
            //else 
            //{
            //    Console.WriteLine("no such acaddemy");
            //} 
            //    return false;
        }
        
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //good example
    //this is the initial student class
    public abstract class StudentGood
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AcademyType Academy { get; set; }
        public abstract bool CheckClassDay(string day);
    }

    // this is the first student type => code
    public class CodeStudent : StudentGood
    {
        public bool HasProject { get; set; }
        public CodeStudent()
        {
            Academy = AcademyType.Code;
        }

        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "friday") return true;
            return false;
        }
    }

    public class DesignStudent : StudentGood
    {
        public int Homeworks { get; set; }
        public DesignStudent()
        {
            Academy = AcademyType.Design;
        }

        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "wednesday" || day == "friday") return true;
            return false;
        }
    }

    public class NetworkStudent : StudentGood
    {
        public int Grade { get; set; }
        public NetworkStudent()
        {
            Academy = AcademyType.Network;
        }

        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "thursday" || day == "friday") return true;
            return false;
        }
    }

    //we can have as many types of students in the future as we need
    //and we add them without changing anything in the implementation that is working
    //before the need to extend with more student types

















    public enum AcademyType
    {
        None, 
        Code,
        Design,
        Network
        //in the future we might extent this enum with as many types of academies as we want
        //...Art
        //...Science
        //...
    }
}
