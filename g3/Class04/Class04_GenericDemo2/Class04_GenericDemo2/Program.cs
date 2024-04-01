using Models;
using System.Security.Cryptography.X509Certificates;

namespace Class04_GenericDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            User u = new User("Risto", "risto", "A000123", "sb/test");
            Loan l = new Loan(u, 10000, "sb/test");

            Thread.Sleep(5000);
            u.IdNumber = "M123123";
            u = AuditHelper<User>.SetUpdateParams(u, "sb/test2");

            Thread.Sleep(5000);
            l.Amount -= 5000;
            l = AuditHelper<Loan>.SetUpdateParams(l, "sb/test2");
        }
    }
}
