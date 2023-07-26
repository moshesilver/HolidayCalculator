using System;

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

    public class HolidayCalculator
    {
        public int FirstSunday(int _year, int month)
        {
            DateTime day1 = new(_year, month, 1);
            return (7 - Convert.ToInt32(day1.DayOfWeek));
        }
        public List<DateTime> CalculateHolidays(int year)
        {
            List<DateTime> holidays = new();


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
            int daysToMon = FirstSunday(year, 5) + 1;
            if (daysToMon >= 7) { daysToMon -= 7; }
            int daysAfterMonInMay = 31 - daysToMon;
            int memorialDay = ((daysToMon + 1) + (daysAfterMonInMay -= (daysAfterMonInMay % 7)));
            if (memorialDay > 31) { memorialDay -= 7; }
           

            //LABOR DAY
            int _daysToMon = FirstSunday(year, 9) + 1;
            if (_daysToMon >= 7) { _daysToMon -= 7; }
            int laborDay = _daysToMon + 1;
           

            //THANKSGIVING
            int daysToThurs = FirstSunday(year, 11) + 4;
            if (daysToThurs >= 7) { daysToThurs -= 7; }
            int thursday = daysToThurs + 1;
            int thanksgiving = thursday + 21;




            holidays.Add(new DateTime(year, 5, memorialDay));//Memorial Day

            holidays.Add(new DateTime(year, 7, 4));//Independence Day

            holidays.Add(new DateTime(year, 9, laborDay));//Labor Day

            holidays.Add(new DateTime(year, 11, thanksgiving));//Thanksgiving

            holidays.Add(new DateTime(year, 12, 25));//Christmas

            holidays.Add(new DateTime((year + 1), 1, 1));//New Year's
                                    //year starts on 1/5
            
            List<string> holidayNames = new()
            {
                "Memorial Day",
                "Independence Day",
                "Labor Day",
                "Thanksgiving",
                "Christmas",
                "New Year's"
            };
            int i = 0;
            foreach (var holiday in holidays)
            {
                Console.WriteLine($"{holidayNames[i]}: {holiday.ToShortDateString()}");//LATER ADD ACCOMPANIED HOLIDAY NAMES IN LIST
                i++;
            }

            return holidays;//these holidays include times (all of them are midnight)
        }
    }
}
