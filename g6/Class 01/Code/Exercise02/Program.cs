//The app should request for a user to enter a date as an input or multiple inputs
//The app should then open and see if the day is a working dayday
//It should show the user a message whether the date they entered is working or not
//Weekends are not working
//1 January, 7 January, 20 April, 1 May, 25 May, 2 August, 8 September, 11 October, 23 October and 8 December
//are not working days as well
//It should ask the user if they want to check another date
//Yes - the app runs again
//No - the app closes

try
{
    List<DateTime> holidays = new List<DateTime>()
    {
        new DateTime(DateTime.Now.Year, 1,1),
        new DateTime(DateTime.Now.Year, 1,7),
        new DateTime(DateTime.Now.Year, 4,20),
        new DateTime(DateTime.Now.Year, 5,1),
        new DateTime(DateTime.Now.Year, 5,25),
        new DateTime(DateTime.Now.Year, 8,2),
        new DateTime(DateTime.Now.Year, 9,8),
        new DateTime(DateTime.Now.Year, 10,11),
        new DateTime(DateTime.Now.Year, 10,23),
        new DateTime(DateTime.Now.Year, 12, 8),
    };
    while (true)
    {
        Console.WriteLine("Enter a date in the following format: mm/dd/yyyy"); //the format depends on how the date is set on your server (computer)
        DateTime date = DateTime.Parse(Console.ReadLine()); //potential FormatException

        //check if it is the weekend
        if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Weekend!");
        }
        //check if the date is one of the dates in holidays
        // else if(holidays.Where(x => x.Day == date.Day && x.Month == date.Month && x.Year == date.Year).ToList().Count() > 0)
        else if (holidays.Any(x => x.Day == date.Day && x.Month == date.Month && x.Year == date.Year))
        {
            Console.WriteLine("Holidayy!");
        }
        else
        {
            Console.WriteLine("Working day :(");
        }

        Console.WriteLine("Press x if you want to exis or any other key to continue");
        string input = Console.ReadLine();
        if(input.ToLower() == "x")
        {
            break;
        }
    }
}catch(FormatException e)
{
    Console.WriteLine("Wrong input!");
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}

