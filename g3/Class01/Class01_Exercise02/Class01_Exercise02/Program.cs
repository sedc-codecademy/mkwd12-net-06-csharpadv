namespace Class01_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> nonWorkingDays = new List<DateTime>
            {
                new DateTime(2024, 1, 1),
                new DateTime(2024, 1, 7),
                new DateTime(2024, 4, 20),
                new DateTime(2024, 5, 1),
                new DateTime(2024, 5, 25),
                new DateTime(2024, 8, 3),
                new DateTime(2024, 9, 8),
                new DateTime(2024, 10, 12),
                new DateTime(2024, 10, 23),
                new DateTime(2024, 12, 8)
            };

            while (true)
            {
                Console.WriteLine("Please enter a date in format <day.month.year>");
                string inputDate = Console.ReadLine();

                if (!DateTime.TryParse(inputDate, out DateTime date))
                {
                    Console.WriteLine("Wrong date format");
                    continue;
                }

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Non-working day");
                }
                else if (nonWorkingDays.Any(x => x.Day == date.Day && x.Month == date.Month))
                {
                    Console.WriteLine("Non-working day");
                }
                else
                {
                    Console.WriteLine("Working day");
                }

                Console.WriteLine("If you want to enter new date, press 'y'");
                string input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}