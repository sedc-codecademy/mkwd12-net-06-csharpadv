using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Exercises02.Services
{
    public class FreeDayService
    {
        public bool CheckIfDateIsNonWorkingDay(DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) |
                ((date.Month == 1 && date.Day == 1) || (date.Month == 1 && date.Day == 7)) |
                (date.Month == 4 && date.Day == 20) |
                (date.Month == 5 && (date.Day == 1 || date.Day == 25)) |
                (date.Month == 8 && date.Day == 3) |
                (date.Month == 9 && date.Day == 8) |
                (date.Month == 10 && (date.Day == 12 || date.Day == 23)) |
                (date.Month == 12 && date.Day == 8);
        }

        public bool CheckIfDateIsNonWorkingDaySecondWay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }

            if ((date.Month == 1 && date.Day == 1) || (date.Month == 1 && date.Day == 7))
            {
                return true;
            }
            else if (date.Month == 4 && date.Day == 20)
            {
                return true;
            }
            else if (date.Month == 5 && (date.Day == 1 || date.Day == 25))
            {
                return true;
            }
            else if (date.Month == 8 && date.Day == 3)
            {
                return true;
            }
            else if (date.Month == 9 && date.Day == 8)
            {
                return true;
            }
            else if (date.Month == 10 && (date.Day == 12 || date.Day == 23))
            {
                return true;
            }
            else if (date.Month == 12 && date.Day == 8)
            {
                return true;
            }

            return false;
        }

    }
}
