using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterface.Domain.Models
{
    public class JuniorDeveloper : Developer
    {
        public bool IsGraduated { get; set; }

        public JuniorDeveloper() { }

        public JuniorDeveloper(string fullName, int age, string address, long phoneNumber, string projectName, int years,
            List<string> languages, bool isGraduated) : base(fullName, age, address, phoneNumber, projectName,years, languages)
        {
            IsGraduated = isGraduated;
        }
    }
}
