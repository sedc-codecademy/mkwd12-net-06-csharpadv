List<string> names = new List<string> { "Paul", "Kate", "John", "Ema" };

//names.Count == 0
//if we want to save an expression (anonymous method) that returns a value, and can have but doens't have to have parameteres
//we would use Func
//Func<List<string>, bool> - reading this from left to right means that:
//the expression takes some input data that is of type List<string> and returns a value that is of type bool
Func<List<string>, bool> checkIfListIsEmpty = x => x.Count == 0;

bool namesIsEmpty = checkIfListIsEmpty(names);

if (checkIfListIsEmpty(names))
{

}
else
{

}

//the method doesn't have to have parameters, it can just return a value
//having just one type between the angle brackets for Func, means the expression just returns a value, doesn't have params
Func<int> sum = () => 5 + 2;
Console.WriteLine(sum());

//always read from the left to right, this means we have two int input params and int return value
//the last one is always the return value
Func<int, int, int> sumOfTwoNums = (x, y) => x + y;

//multiple lines of code
Func<int, int, bool> firstNumIsLarger = (x, y) =>
{
    if (x > y)
        return true;
    return false;
};
bool isFirstLarger = firstNumIsLarger(10, 2);

List<int> numbers = new List<int> { 4, 67, 5, 2, 1 };
Func<int, bool> isEven = x => x % 2 == 0;

//List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
List<int> evenNumbers = numbers.Where(isEven).ToList();

//List<string> filteredNames = names.Where(x => x.StartsWith("J")).ToList();
Func<string, bool> startsWithJ = x => x.StartsWith("J");
List<string> filteredNames = names.Where(startsWithJ).ToList();

//ACTION
//the expression here is void and it also doesn't have params
//that's why we don't have angle brackets
Action sayHi = () => Console.WriteLine("Hi");

//the expression is void and has only one param of type string
Action<string> greetingMessage = x => Console.WriteLine($"Hello {x}");

Action<string, string> message = (name, academy) =>
{
    Console.WriteLine($"This is {name}");
    Console.WriteLine($"{name} studies at the {academy} academy");
};
message("Tanja", "Qinshift");