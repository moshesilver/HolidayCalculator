using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            HolidayCalculator holidayCalculator = new();
            Console.WriteLine("Enter a year");
            int chosenYear = Convert.ToInt32(Console.ReadLine());
            List<DateTime> actualOffDays = holidayCalculator.CalculateHolidays(chosenYear);

            /*
            int i = 0;
            foreach (var holiday in holidays)
            {
                Console.WriteLine($"{holidayCalculator.holidayNames[i]}: {holiday.ToShortDateString()}");
                i++;
            }
            */
            Console.WriteLine("Actual off days for each of the following holidays:");
            int i = 0;
            foreach (var offDay in actualOffDays)
            {
                Console.WriteLine($"{holidayCalculator.holidayNames[i]}: {offDay.ToShortDateString()}");
                i++;
            }
        }
    }

    public enum Month //not used as of now
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
