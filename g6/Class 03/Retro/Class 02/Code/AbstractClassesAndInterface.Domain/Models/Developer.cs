using AbstractClassesAndInterface.Domain.Interfaces;

namespace AbstractClassesAndInterface.Domain.Models
{
    public class Developer : Person, IDeveloper
    {
        public string ProjectName {  get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> ProgrammingLanguages { get; set; }

        public Developer()
        {

        }

        public Developer(string fullName, int age, string address, long phoneNumber, string projectName, int years, 
            List<string> languages) //when we create a Developer, this constructor is called(we call it with all these properties)
            : base(fullName, age, address, phoneNumber) //here the Developer constructor calls the Person constr with the params that it wants to be handled there
        {
            ProjectName = projectName;
            YearsOfExperience = years;
            ProgrammingLanguages = languages == null ? new List<string>() : languages;
        }

        //this method must be present because it is an abstract method in the parent class (Person)
        public override string GetProfessionalInfo()
        {
            return $"{FullName} works as a developer for {YearsOfExperience}. {FullName} works on {ProjectName}";
        }

        public void Code()
        {
            Console.WriteLine("Coding... \n");
            if(ProgrammingLanguages.Count > 0)
            {
                foreach(var language in ProgrammingLanguages)
                {
                    Console.WriteLine($"Programming in {language} \n");
                }
            }
        }
    }
}
