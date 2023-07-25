using System;

namespace HolidayCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            HolidayCalculator holidayCalculator = new HolidayCalculator();
            Console.WriteLine("Enter a year");
            int chosenYear = Convert.ToInt32(Console.ReadLine());
            holidayCalculator.CalculateHolidays(chosenYear);
            
        }
    }
    
    public enum Month//FOR LATER
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

    public class HolidayCalculator
    {
        public List<DateTime> CalculateHolidays(int year)
        {
            //LATER ADD MONTH VARIABLE SO I CAN REUSE FUNCTIONS AND VARIABLES
            List<DateTime> holidays = new List<DateTime>();

            //MEMORIAL DAY
            DateTime firstDayOfMay = new DateTime(year, 5, 1);

            //replace 5 with 'month'
            //replace May with 'Month'
            //if ()initialize beforehand but empty

            /*int daysToSun = week - Convert.ToInt32(firstDayOfMay.DayOfWeek);
            if (daysToSun == week) { daysToSun = 0; }
            int sunday = daysToSun + 1;
            int daysAfterSunInMay = 31 - daysToSun;
            int weeksInMay = daysAfterSunInMay / week;
            int daysToLastSun = weeksInMay * week;
            int lastSunInMay = sunday + daysToLastSun;
            int lastMonInMay = lastSunInMay + 1;
            if (lastMonInMay > 31) { lastMonInMay -= week; }*/

            int daysToSun = 7 - Convert.ToInt32(firstDayOfMay.DayOfWeek);
            if (daysToSun == 7) { daysToSun = 0; }
            int daysAfterSunInMay = 31 - daysToSun;
            int lastMonInMay = ((daysToSun + 1) + (daysAfterSunInMay -= (daysAfterSunInMay % 7))) + 1;
            if (lastMonInMay > 31) { lastMonInMay -= 7; }

            //may has 31 days so for the last week in may substract daysToSun(without the +1) from 31
            //then divide by 7 which will tell you how many weeks there are in may starting from the first sunday
            //then you should add that many weeks of days to sunday to get the last sunday in may

            DateTime MemorialDay = new DateTime(year, 5, lastMonInMay);//LATER REMOVE THIS LINE AND PUT DIRECTLY INTO holidays.Add()

            // Console.WriteLine($"Memorial Day in {year} is: May {lastMonInMay}th!");//for testing memorial day

            //LABOR DAY
            int monday;
            DateTime firstDayOfSeptember = new DateTime(year, 9, 1);
            if (firstDayOfSeptember.DayOfWeek == DayOfWeek.Monday) { monday = 1; }
            else
            {
                int daysToMon = (7 - Convert.ToInt32(firstDayOfSeptember.DayOfWeek)) + 1;
                if (daysToMon == 8) { daysToMon = 1; }
                else if (daysToMon == 7) { daysToMon = 0; }//just in case (should be impossible)
                monday = daysToMon + 1;
            }

            DateTime LaborDay = new DateTime(year, 9, monday);//LATER REMOVE THIS LINE AND PUT DIRECTLY INTO holidays.Add()





            //REMEMBER TO REMOVE TIMES (ONLY RETURN DATES)


            holidays.Add(MemorialDay);//Memorial Day

            holidays.Add(new DateTime(year, 7, 4));//Independence Day

            holidays.Add(LaborDay);//Labor Day

            holidays.Add(new DateTime(year, 12, 25));//Christmas Day

            holidays.Add(new DateTime(year, 1, 1));//New Year's Day MAYBE SHOULD BE FOR NEXT YEAR BECAUSE YEAR STARTS AFTER THIS
                                                   //MAYBE SAY year + 1
            /*

            holidays.Add(new DateTime(year, 11, ));//Thanksgiving

            */

            foreach (var holiday in holidays)
            {
                Console.WriteLine(holiday.ToString());//LATER ADD ACCOMPANIED HOLIDAY NAMES IN LIST
            }

            return holidays;
        }
    }
}
