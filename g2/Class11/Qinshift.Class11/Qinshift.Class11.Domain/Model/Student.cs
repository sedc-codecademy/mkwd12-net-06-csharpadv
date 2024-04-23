
using System.Runtime.Serialization;

namespace Qinshift.Class11.Domain.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool isPartTime { get; set; }

        public Student()
        {

        }

        [OnSerializing]		// Method called on serializing
        public void OnSerilizeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE SERIALIZING A STUDENT!");
        }

        [OnDeserializing] 		// Method called on deserializing
        public void OnDeSerilizeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE DESERIALIZING A STUDENT!");
        }
    }
}
