using System;
using System.Security.Cryptography.X509Certificates;

namespace HolidayCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            HolidayCalculator holidayCalculator = new();
            Console.WriteLine("Enter a year");
            int chosenYear = Convert.ToInt32(Console.ReadLine());
            holidayCalculator.CalculateHolidays(chosenYear);
            
        }
    }
    
    public enum Month
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
        public int FirstSunday(int _year, Month m)
        {
            DateTime day1 = new DateTime(_year, Convert.ToInt32(m), 1);
            return (7 - Convert.ToInt32(day1.DayOfWeek));
        }
        public List<DateTime> CalculateHolidays(int year)
        {
            //LATER ADD MONTH VARIABLE SO I CAN REUSE FUNCTIONS AND VARIABLES
            List<DateTime> holidays = new();




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

            //may has 31 days so for the last week in may substract daysToSun(without the +1) from 31
            //then divide by 7 which will tell you how many weeks there are in may starting from the first sunday
            //then you should add that many weeks of days to sunday to get the last sunday in may


            //MEMORIAL DAY
            int daysToMon = FirstSunday(year, Month.May) + 1;
            if (daysToMon >= 7) { daysToMon -= 7; }
            int daysAfterMonInMay = 31 - daysToMon;
            int lastMonInMay = ((daysToMon + 1) + (daysAfterMonInMay -= (daysAfterMonInMay % 7)));
            if (lastMonInMay > 31) { lastMonInMay -= 7; }
            
            DateTime MemorialDay = new(year, 5, lastMonInMay);//LATER REMOVE THIS LINE AND PUT DIRECTLY INTO holidays.Add()


            //LABOR DAY
            int daysToMon_ = FirstSunday(year, Month.September) + 1;
            if (daysToMon_ >= 7) { daysToMon_ -= 7; }
            int monday = daysToMon_ + 1;
            
            DateTime LaborDay = new (year, 9, monday);//LATER REMOVE THIS LINE AND PUT DIRECTLY INTO holidays.Add()


            //THANKSGIVING
            int daysToThurs = FirstSunday(year, Month.November) + 4;
            if (daysToThurs >= 7) { daysToThurs -= 7; }
            int thursday = daysToThurs + 1;
            int fourthThursInNovember = thursday + 21;

            DateTime Thanksgiving = new (year, 11, fourthThursInNovember);//LATER REMOVE THIS LINE AND PUT DIRECTLY INTO holidays.Add()




            holidays.Add(MemorialDay);//Memorial Day

            holidays.Add(new DateTime(year, 7, 4));//Independence Day

            holidays.Add(LaborDay);//Labor Day

            holidays.Add(Thanksgiving);//Thanksgiving

            holidays.Add(new DateTime(year, 12, 25));//Christmas Day

            holidays.Add(new DateTime((year + 1), 1, 1));//New Year's Day
            
            

            foreach (var holiday in holidays)
            {
                Console.WriteLine(holiday.ToShortDateString());//LATER ADD ACCOMPANIED HOLIDAY NAMES IN LIST
            }

            return holidays;
        }
    }
}
