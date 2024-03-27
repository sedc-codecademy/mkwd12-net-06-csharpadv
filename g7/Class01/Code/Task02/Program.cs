List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(DateTime.Now.Year, 1, 1),
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 4, 20),
                new DateTime(DateTime.Now.Year, 4, 30),
                new DateTime(DateTime.Now.Year, 5, 1),
                new DateTime(DateTime.Now.Year, 5, 3),
                new DateTime(DateTime.Now.Year, 5, 25),
                new DateTime(DateTime.Now.Year, 8, 2),
                new DateTime(DateTime.Now.Year, 9, 8),
                new DateTime(DateTime.Now.Year, 10, 12),
                new DateTime(DateTime.Now.Year, 10, 23),
                new DateTime(DateTime.Now.Year, 12, 10)
            };

while (true)
{
    try
    {
        //you should expect a string in the format that dates are represented on your machine
        Console.WriteLine("Please enter a date for check in format month/day/year");
        string inputDate = Console.ReadLine();


        bool successfulParse = DateTime.TryParse(inputDate, out DateTime selectDate);
        if (!successfulParse)
        {
            Console.WriteLine("Wrong input for date");
            continue;
        }

        if (selectDate.DayOfWeek == DayOfWeek.Saturday || selectDate.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Not working day");
            continue;
        }

        List<DateTime> filteredDates = holidays.Where(x => x.Day == selectDate.Day && x.Month == selectDate.Month && x.Year == selectDate.Year)
            .ToList();
        if (filteredDates.Count > 0){
        }

        if (holidays.Any(x => x.Day == selectDate.Day && x.Month == selectDate.Month && x.Year == selectDate.Year))
        {
            Console.WriteLine("Not working day");
            continue;
        }

        Console.WriteLine("Working day");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}