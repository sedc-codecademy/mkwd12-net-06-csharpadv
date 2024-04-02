namespace Class04_GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "risto", "slave", "sasho", "boris" };
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };

            //foreach(int item in numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //foreach (string item in names)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //ListHelper.PrintItem(numbers);
            //ListHelper.PrintItem(names);

            ListHelper.PrintItem<int>(numbers);

            List<char> chars = new List<char> { 'c', 'a', 'b' };
            ListHelper.PrintItem<char>(chars);

            ListHelper.PrintItem<string>(names);

            List<User> list = new List<User>
            {
                new User("Risto", "Panchevski"),
                new User("Slave", "Ivanovski")
            };

            ListHelper.PrintItem<User>(list);
            ListHelper.PrintUserItem<User>(list);

            List<Student> listStudent = new List<Student>
            {
                new Student("Marko", "Markovski", "marko@mail.com"),
                new Student("Ivan", "Ivanovski", "ivan@mail.com")
            };

            ListHelper.PrintUserItem<Student>(listStudent);
        }
    }
}
