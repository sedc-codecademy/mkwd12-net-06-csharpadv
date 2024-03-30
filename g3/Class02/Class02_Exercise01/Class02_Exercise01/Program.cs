using Models;

namespace Class02_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher("Risto", "risto", "123", "C# Basic");
            Teacher teacher2 = new Teacher("Slave", "slave", "321", "C# Advance");

            Console.WriteLine(teacher1.GetUser());
            Console.WriteLine(teacher2.GetUser());

            var student1 = new Student("Petko", "petko", "123", new List<int> { 5, 5, 5, 5 });
            var student2 = new Student("Mitko", "mitko", "123", new List<int> { 5, 5, 5, 5, 4 });

            Console.WriteLine(student1.GetUser());
            Console.WriteLine(student2.GetUser());

            DateTime now = DateTime.Now;
        }
    }
}
