using QinshiftAcademy.Class02.AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class02.AbstractClasses.Models
{
    public class SoftwareDeveloper : Person, ISoftwareDeveloper, IEngineer
    {
        public string ProjectName { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
        public SoftwareDeveloper(string firstName, string lastName, long phoneNumber, string address, string project) :
            base(firstName, lastName, phoneNumber, address)
        {
            ProjectName = project;
            ProgrammingLanguages = new List<string>() { "C#" };
        }

        //this method MUST have an implementation here, if we don't provide implementation, this class will also
        //be marked as abstract
        public override void PrintInfo()
        {
            Console.WriteLine($"Software developer: {FirstName} {LastName} works on project {ProjectName} ");

            if (ProgrammingLanguages != null && ProgrammingLanguages.Count > 0)
            {
                Console.WriteLine($"{FirstName} {LastName} knows the following programming languages:");
                foreach(string language in ProgrammingLanguages)
                {
                    Console.WriteLine(language);
                }
            }
        }

        public void Code()
        {
            Console.WriteLine($"{FirstName} {LastName} is coding using the following languages:");
            foreach (string language in ProgrammingLanguages)
            {
                Console.WriteLine(language);
            }
        }

        public string GetEngineeringSchoolName()
        {
            return "Coding school";
        }
    }
}
