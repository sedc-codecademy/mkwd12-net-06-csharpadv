using AdvancedLINQ.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }

        public int Modules { get; set; }

        public int StudentsAttending { get; set; }
        public AcademyTypeEnum AcademyType { get; set; }

        public Subject() { }

        public Subject(int id, string title, int modules, int studentsAttening, AcademyTypeEnum academyType)
        {
            Id = id;
            Title = title;
            Modules = modules;
            StudentsAttending = studentsAttening;
            AcademyType = academyType;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} has {Modules} modules, Academy - {AcademyType.ToString()} and has {StudentsAttending} students attending");
        }
    }
}
