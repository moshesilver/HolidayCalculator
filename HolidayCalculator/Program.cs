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
            Console.WriteLine("Enter a year");
            int chosenYear = Convert.ToInt32(Console.ReadLine());
            OffDayCalculator offDayCalculator = new(chosenYear);
            List<DateTime> holidayOffDays = offDayCalculator.CalculateHolidayOffDays(offDayCalculator.Year);


            Console.WriteLine("Actual off days for each of the following holidays:");
            int i = 0;
            foreach (var offDay in holidayOffDays)
            {
                Console.WriteLine($"{offDayCalculator.holidayNames[i]}: {offDay.ToShortDateString()}");
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
