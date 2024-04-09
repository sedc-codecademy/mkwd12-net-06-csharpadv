namespace Class06_AnonymusFuncDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //() => { }
            //Func<int, int, int> sumFunc = (a, b) =>
            //{
            //    return a + b;
            //};

            Func<int, int, int> sumFunc = (a, b) => a + b;

            int result = sumFunc(1, 7);

            //Program.Sum(Console.ReadLine(), Console.ReadLine(), sumFunc);

            //Func<string> helloMessage = () => { return "Hello SEDC!"; };


            Func<string> helloMessage = () => "Hello SEDC!";

            Console.WriteLine(helloMessage());

            Action<string, string> printFullName = (firstName, lastName) =>
            {
                Console.WriteLine($"{firstName} {lastName}");
            };

            printFullName("Risto", "Panchevski");

            Action<string, List<string>> printStudents = (message, list) =>
            {
                Console.Write(message);
                Console.WriteLine(string.Join(", ", list));
            };

            List<string> studentsThatPassed = new List<string> { "Marko", "Slave", "Mitko" };
            List<string> studetnsThatFailed = new List<string> { "Petko", "Mile" };

            printStudents("Students that have passed: ", studentsThatPassed);
            printStudents("Students that have failed: ", studetnsThatFailed);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Green");
            //Console.ForegroundColor = ConsoleColor.White;

            Action<string, ConsoleColor> print = (message, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            };

            print("Green", ConsoleColor.Green);
            print("Red", ConsoleColor.Red);
            print("Yellow", ConsoleColor.Yellow);

            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            studentsThatPassed.Where(x => x.StartsWith("M"));

            Func<string, bool> namesWithM = (x) =>
            {
                return x.StartsWith("M");
            };
            studentsThatPassed.Where(namesWithM);

            Action<string> foreachAction = (name) =>
            {
                print(name, ConsoleColor.Blue);
            };

            //studentsThatPassed.ForEach(x => print(x, ConsoleColor.Blue));
            studentsThatPassed.ForEach(foreachAction);
        }

        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        static int Sum(string a, string b, Func<int, int, int> operation)
        {
            int number1 = int.Parse(a);
            int number2 = int.Parse(b);
            int result = operation(number1, number2);
            return result;
        }
    }
}
