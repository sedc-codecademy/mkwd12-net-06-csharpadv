using QinshiftAcademy.Class02.AbstractClasses.Interfaces;
using QinshiftAcademy.Class02.AbstractClasses.Models;

//Person person = new Person(); ERROR - the class is abstract

SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper("Marko", "Markovski", 453534, "Test Address", "E-Store");
softwareDeveloper.PrintInfo(); //implementation from SoftwareDeveloper

softwareDeveloper.Code(); //implementation from SoftwareDeveloper

softwareDeveloper.TestMethod(); //inherited from Person class

QAEngineer qaEngineer = new QAEngineer("Kate", "Katesky", 438475834, "Address 2", 5);
qaEngineer.PrintInfo(); //implementation from QAEngineer

qaEngineer.TestMethod(); //inherited from Person class

//the method signature comes from the IEngineer interface
Console.WriteLine(qaEngineer.GetEngineeringSchoolName()); //method with specific implementation in QAENgineer class
qaEngineer.TestFeature("Adding users", new DateTime(2024, 5, 1));


//Sales sales = new Sales("Marko", "Markovski", 453534, "Test Address"); ERROR - abstract class

SalesManager salesManager = new SalesManager("Paul", "Paulsky", 7878787, "Address 3");
salesManager.PrintInfo(); // specific

salesManager.TestMethod(); // comes from Person class

//ISoftwareDeveloper developer = new ISoftwareDeveloper() -objects can not be instantiated from interfaces