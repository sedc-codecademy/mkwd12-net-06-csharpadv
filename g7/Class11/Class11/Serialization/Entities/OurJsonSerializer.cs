namespace Serialization.Entities
{
    public class OurJsonSerializer
    {
        public string SerializeStudent(Student student)
        {
            // what happens in the background => how a json object is formed from a c# class
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";
            return json;
        }

        public Student DeserializeStudent(string json)
        {
            // what happens in the background => how a c# class object is formed from a JSON

            //Cleaning the Json
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");
            string[] properties = content.Split(',');

            // Crating dictionary with clean keys (properties) and values
            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            //Creating a student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["firstName"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["firstName"]);

            return student;
        }
    }
}
