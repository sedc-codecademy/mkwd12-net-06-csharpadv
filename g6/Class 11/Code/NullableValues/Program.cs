using NullableValues;

Person person = new Person();
Console.WriteLine(person.Id); //0 by default
Console.WriteLine(person.Score); //null by default

if(person.Score == null) //if(!person.Score.HasValue)
{
    Console.WriteLine("Score is null");
}

if(person.Score.HasValue) //same as (person.Score != null)
{
    Console.WriteLine(person.Score);
}

person.Score = 100;

if (person.Score.HasValue) //same as (person.Score != null)
{
    Console.WriteLine(person.Score);
   // int score = person.Score; ERROR int != int?
   int score = person.Score.Value; //with value we access the value if there is one

    int? secondScore = person.Score; //this is ok
}

//person.Id = null; ERROR int is a not nullable type
//person.Score = null;

//person.IsStudent = null; ERROR - not nullable
person.IsEmployed = null;
person.IsEmployed = true;

if(person.Name == null)
{
    Console.WriteLine("name is null");
}

if (person.Numbers == null)
{
    Console.WriteLine("The list numbers has null value");
}

Person secondPerson = new Person();
secondPerson = null; //every object is nullable

//? is an operator that checks for null values. If the left side of the operator has value null it returns null
//as result instead of throwing an exception. If the left side is not null it will access the property/method
string name = secondPerson?.Name;
//string wrongName = secondPerson.Name; here an exception will be thrown because we ary trying to access null.Name