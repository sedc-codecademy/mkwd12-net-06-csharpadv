using AbstractClassesAndInterface.Domain.Models;

Developer firstDeveloper = new Developer("Petko P", 26, "Some address", 070123456, "SEDC", 4, null);
//Person person = new Person(); ERROR => abstract class
firstDeveloper.GetInfo(); //we call the impl from the Person class
Console.WriteLine(firstDeveloper.GetProfessionalInfo()); //here we call the imp from the Developer class

JuniorDeveloper junior = new JuniorDeveloper("Nikola N", 30, "Some address2", 070456789, "SEDC", 5, new List<string> { "JS", "C#"}, true);
Console.WriteLine(junior.GetProfessionalInfo());

//inherited from Person
firstDeveloper.Greet(); 
firstDeveloper.SendGift("flowers");

//the method that was implemented because Developer implements IDeveloper
firstDeveloper.Code();
junior.Code();
//firstDeveloper.TestingFeatures(); //ERROR -> Developer does not implement IQAEngineer interface

QAEngineer qAEngineer = new QAEngineer("Marko M", 30, "Address 3", 78987654, 3, new List<string> { "Selenium" });
//inherited from Person
qAEngineer.Greet();
qAEngineer.SendGift("gift card");

//comes from IDeveloper interface
qAEngineer.Code();

//comes from IQAEngineer interface
qAEngineer.TestingFeature("Finance module", new DateTime(2024, 07, 01));


DevOpsEngineer devOpsEngineer = new DevOpsEngineer("Ana A", 25, "Address 4", 78345654, true, false);

//inherited from Person, comes from IPerson interface
devOpsEngineer.Greet();

Console.WriteLine(devOpsEngineer.GetProfessionalInfo()); //inherited from Person

//comes from IDevOpsEngineer interface
Console.WriteLine(devOpsEngineer.CheckInfrastucture(500));

//comes from IDeveloper interface
devOpsEngineer.Code();


//BOXING AND UNBOXING

Developer developer = new Developer("Petko P", 26, "Some address", 070123456, "SEDC", 4, null);

//Boxing
Person person = (Person)developer;  //here we cast the developer to be a person -> it only has the properties and method that  the Person class has

//Unboxing
Developer dev = (Developer)person;

//List<Developer> developers;
//List<DevOpsEngineer> devops;
//List<QAEngineer> qa;


//Boxing all children to parent Person class, so that they can fit in one List of the same data type (Person)
List<Person> employees = new List<Person>() { developer, devOpsEngineer, qAEngineer, junior, dev, person };

foreach(Person employee in employees)
{
    Console.WriteLine(employee.FullName);
}