

using QinshiftAcademy.Class06.AdvancedLINQ.Enums;

namespace QinshiftAcademy.Class06.AdvancedLINQ.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int Modules { get; set; }
        public int NumberOfStudents { get; set; }
        public AcademyType AcademyType { get; set; }

        public Subject() { }

        public Subject(int id, string title, int modules, int numOfStudents, AcademyType academyType)
        {
            Id = id;
            Title = title;
            Modules = modules;
            NumberOfStudents = numOfStudents;
            AcademyType = academyType;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} has {Modules} number of modules and is part of {AcademyType.ToString()}");
        }
    }
}
