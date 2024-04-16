using System.Text;

namespace Class08_DelegateDemo
{
    internal class Program
    {

        public delegate void GreetingDelegate(string name);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //GreetingDelegate greeting1;

            //greeting1 = SayHi;

            //greeting1("Risto");

            //GreetingDelegate greeting2;
            //greeting2 = SayZdravo;
            //greeting2("Risto");

            GreetingDelegate greetings;

            greetings = SayHi;
            greetings += SayZdravo;

            //greetings("Risto");

            greetings += (x) => Console.WriteLine($"Cao {x}");


            //greetings("Slave");

            WelcomeUser("Risto", greetings);
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }

        public static void SayZdravo(string name)
        {
            Console.WriteLine($"Здраво {name}");
        }

        public static void WelcomeUser(string name, GreetingDelegate func)
        {
            func(name);
        }
    }
}
