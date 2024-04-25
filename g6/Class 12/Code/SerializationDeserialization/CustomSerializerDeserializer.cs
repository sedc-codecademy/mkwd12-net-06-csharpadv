﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    public static class CustomSerializerDeserializer
    {

        public static string SerializeStudent(Student student)
        {
            //we are trying to convert our student into JSON format which is key value pairs
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";
            return json ;
        }

        public static Student DeserializeStudent(string json)
        {
            //clean the json string from unnecessary characters
            //we use substring to get only the content between the {}
            //we dont want to include the {} that's why we go one character after { and one char before }

            //{"FirstName" :"Ana", "LastName":"Stojanovska", "Age":"25", "IsPartTime":"false"}
            string content = json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\n", "")
                .Replace("\r", "")
                .Replace("\"", "");

            //FirstName:Ana, LastName:Stojanovska, Age:25, IsPartTime:false
            string[] properties = content.Split(","); 

            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach(string property in properties)
            {
                string[] pair = property.Split(":");
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim()); //we are adding our key and our value to the dictionary
            }

            //Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"]; //we are using the key to access the value
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }
}
