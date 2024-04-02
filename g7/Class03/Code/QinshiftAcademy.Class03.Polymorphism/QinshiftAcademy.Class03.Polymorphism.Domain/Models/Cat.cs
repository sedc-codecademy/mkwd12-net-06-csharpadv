

namespace QinshiftAcademy.Class03.Polymorphism.Domain.Models
{
    public class Cat : Pet
    {
        public int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("This is the Eat method from the Cat class");
        }
    }
}
