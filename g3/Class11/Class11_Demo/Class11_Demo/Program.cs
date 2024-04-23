using System.Text;

namespace Class11Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User { 
                FirstName = "Risto",
                LastName = "Panchevski",
                Age = 34
            };


            var userSerialized = SerializeUser(user);

            var user1 = DeserializeUser(userSerialized);
        }

        static string SerializeUser(User user)
        {
            //string result = "{";
            //result += "\"firstName\": \"Risto\"";

            var result = new StringBuilder();
            result.AppendLine("{");
            result.AppendLine($"\"firstName\": \"{user.FirstName}\",");
            result.AppendLine($"\"lastName\": \"{user.LastName}\",");
            result.AppendLine($"\"age\": {user.Age}");
            result.AppendLine("}");

            return result.ToString();
        }

        static User DeserializeUser(string json)
        {
            string[] propertyPairs = json.Replace("\r\n", "").Replace("{", "").Replace("}", "").Replace("\"", "").Split(",");
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            foreach(var pair in propertyPairs)
            {
                var prop = pair.Split(":");
                pairs.Add(prop[0], prop[1]);
            }

            var result = new User
            {
                FirstName = pairs["firstName"],
                LastName = pairs["lastName"],
                Age = int.Parse(pairs["age"])
            };

            return result;
        }
    }
}
