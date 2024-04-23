void CalculationWithNoOptionalParams(int num1, int num2, string operation)
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Inavlid operation"); break;
    }
}

CalculationWithNoOptionalParams(3, 4, "+");
//CalculationWithNoOptionalParams(5, 6) //ERROR - we must provide values for all params

//we must provide values for num1 and num2, but if we don't provide value for operation, it will get the + as default
//ALWAYS PUT THE REQUIRED PARAMS FIRST, THEN THE OPTIONAL
void CalculationWithSomeOptionalParams(int num1, int num2, string operation = "+")
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Inavlid operation"); break;
    }
}

CalculationWithSomeOptionalParams(5, 7, "-"); //operation will get the value "-"
CalculationWithSomeOptionalParams(5, 7); //operation will get the value "+"

void CalculationWithAllOptionalParams(int num1 = 0, int num2 = 0, string operation = "+")
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Inavlid operation"); break;
    }
}

CalculationWithAllOptionalParams(); //0,0,+
CalculationWithAllOptionalParams(1); //1,0,+
CalculationWithAllOptionalParams(1, 3); //1,3,+
CalculationWithAllOptionalParams(1, 3, "-"); //1,3,-

//Named arguments
CalculationWithAllOptionalParams(num1: 1, num2:2, operation: "+");
//when using named arguments we can change the order of passing the values
CalculationWithAllOptionalParams(num2: 1, num1: 2, operation: "+");
