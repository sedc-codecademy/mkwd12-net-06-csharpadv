

namespace QinshiftAcademy.Class03.Polymorphism.Domain.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("This is the Eat method from the Pet class");
        }
    }
}
