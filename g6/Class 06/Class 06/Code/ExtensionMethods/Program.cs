using ExtensionMethods;

Employee employee = new Employee();
employee.FirstName = "Petko";
employee.LastName = "Petkovski";
employee.Address = "Address 1";
employee.SetSalary(500);


Employee newEmployee = new Employee();
newEmployee.FirstName = "Stefan";
newEmployee.LastName = "Stefanovski";
newEmployee.Address = "Address 2";
newEmployee.SetSalary(400);


//we call this method through employee instance, because it belongs to the class Employee
int salary = employee.GetSalary();

//we need to call this method using the EmployeeHelper class and pass the employee as an argument
EmployeeHelper.PrintEmployee(employee);

//the first param in Print(this Employee employee, int salary) (the employee) will be replaced by the employee on which we call the method
//it does not see the employee as a param
//the method Print only needs one param - int salary
employee.Print(3);

employee.PrintNoParams();

string text = "Some text about G6 and Qinshift Academy";

//text.Split(" ");
Console.WriteLine(text.Shorten(3));

List<Employee> list = new List<Employee>() { employee, newEmployee };
List<int> ints = new List<int> { 1, 2, 3, 4 };

string infoAbourEmployees = list.Getinfo();
Console.WriteLine(infoAbourEmployees);

string infoAboutInts = ints.Getinfo();
Console.WriteLine(infoAboutInts);