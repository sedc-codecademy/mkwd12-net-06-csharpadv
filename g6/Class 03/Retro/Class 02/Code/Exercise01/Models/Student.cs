using Exercise01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    //Student implemets IUser because Student inherits from User who implents IUser
    public class Student : User, IStudent
    {

        public List<int> Grades { get; set; }   

        public Student(int id, string name, string username, string password, List<int> grades)
            :base(id, name, username, password)
        {
            Grades = grades != null ? grades : new List<int>();
        }

        //we need to implement this method because we implement the IStudent interface
        public void PrintGrades()
        {
            Console.WriteLine($"Student {Username} has grades: ");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
            //there is a method Sum that we can use on a collection of numbers and it will sum all the values
            int averageGrade = Grades.Sum() / Grades.Count();
            Console.WriteLine($"with average grade {averageGrade}");

        }

        //we need an implementation here because we have an abstract method PrintUser in Userr class that comes from interface IUser
        public override void PrintUser()
        {
            Console.WriteLine($"Student with id {Id} name: {Name} has username: {Username} and grades:");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
