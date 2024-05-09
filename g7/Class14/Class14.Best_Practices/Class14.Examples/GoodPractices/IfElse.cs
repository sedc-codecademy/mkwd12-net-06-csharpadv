namespace Class14.Examples.GoodPractices
{
    public class IfElse
    {
        public void IfelseExamples(int num1, int num2)
        {
            //Check if two numbers are the same but only from 2 to 100 even numbers
            //bad example
            if(num1 <= 100 && num2 <= 100)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if(num1 == num2)
                    {
                        Console.WriteLine("The numbers are the same");
                    }
                }
            }

            //good example
            if (num1 > 100 || num2 > 100) return; // return some response that the numbers are in invalid range
            if (num1 % 2 != 0 && num2 % 2 != 0) return;
            if (num1 != num2) return;
            //another check
            //another check
            //..
            //..
            Console.WriteLine("The numbers are the same"); // return response that nums are same
        }
    }
}
