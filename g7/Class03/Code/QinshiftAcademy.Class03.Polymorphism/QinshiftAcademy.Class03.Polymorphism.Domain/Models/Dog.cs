

namespace QinshiftAcademy.Class03.Polymorphism.Domain.Models
{
    public class Dog : Pet
    {
        public string Breed { get; set; }

        public override void Eat()
        {
            Console.WriteLine("This is the Eat method from the Dog class");
        }
    }
}
