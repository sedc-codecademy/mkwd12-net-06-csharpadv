using Qinshift.Exercises02.Services;

while (true)
{
    // Request user input for date
    Console.WriteLine("Enter a date (YYYY-MM-DD):");
    if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
    {
        Console.WriteLine("Invalid date format. Please try again.");
        continue;
    }

    // Check if the date is a working day using the provided function
    FreeDayService freeDayService = new FreeDayService();

    //bool isWorkingDay = !freeDayService.CheckIfDateIsNonWorkingDay(date);
    bool isWorkingDay = !freeDayService.CheckIfDateIsNonWorkingDaySecondWay(date);

    // Display message to user
    if (isWorkingDay)
        Console.WriteLine($"{date.ToShortDateString()} is a working day.");
    else
        Console.WriteLine($"{date.ToShortDateString()} is not a working day.");

    // Ask user if they want to check another date
    Console.WriteLine("Do you want to check another date? (yes/no)");
    string response = Console.ReadLine().ToLower();
    if (response.ToLower() != "yes")
        break;
}