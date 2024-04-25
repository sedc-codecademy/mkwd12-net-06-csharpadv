using Qinshift.Class11.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class11.Service
{
    public class OurJsonSerlizer
    {
        // Serializes only a student object 
        public string SerilizeStudent(Student student)
        {
            string json = "{";
            json += $@"""FirstName"": ""{student.FirstName}"",";
            json += $@"""LastName"": ""{student.LastName}"",";
            json += $@"""Age"": ""{student.Age}"",";
            json += $@"""isPartTime"": ""{student.isPartTime.ToString().ToLower()}""";
            json += "}";
            return json;
        }
        // Deserializes only student object
        public Student DeserializeStudent(string json)
        {
            // THE PROCESS
            /*
            0. {"FirstName" : "Bob","LastName" : "Bobsky","Age" : "40","IsPartTime" : "false"}
            1. FirstName : Bob, LastName : Bobsky,Age : 40,IsPartTime : false
            1.1 
            FirstName : Bob
            LastName : Bobsky
            Age : 40
            IsPartTime : false
            2. 
            Key: FirstName, Value: Bob
            Key: LastName, Value: Bobsky
            Key: Age, Value: 40
            Key: IsPartTime, Value: false
            3 all keys and values to Student properties
            */
            // Cleaning the json
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');

            // Creating dictionary with clean keys( properties ) and values
            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();

            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.isPartTime = bool.Parse(propertiesDictionary["isPartTime"]);

            return student;
        }
    }
}
