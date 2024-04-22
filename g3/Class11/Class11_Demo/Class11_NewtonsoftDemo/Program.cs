using Newtonsoft.Json;

namespace Class11_NewtonsoftDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Risto", "Panchevski", 34);

            Console.WriteLine(user.ToString());

            var userSerialized = JsonConvert.SerializeObject(user);

            var user1 = JsonConvert.DeserializeObject<User>(userSerialized);

            DateTime now = DateTime.Now;
            var nowSerialized = JsonConvert.SerializeObject(now);

        }
    }
}
