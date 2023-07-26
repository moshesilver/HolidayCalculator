namespace HolidayCalculator
{
    public class HolidayCalculator
    {
        public int FirstSundayOfMonth(int _year, int month)
        {
            DateTime day1 = new(_year, month, 1);
            int firstSundayOfMonth = ((7 - Convert.ToInt32(day1.DayOfWeek)) + 1);
            if (firstSundayOfMonth >= 7) { firstSundayOfMonth -= 7; }
            return firstSundayOfMonth;
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


            //MEMORIAL DAY (last monday in may)
            int firstMayMonday = FirstSundayOfMonth(year, 5) + 1;
            int daysAfterFirstMayMonday = 31 - firstMayMonday;
            int memorialDay = firstMayMonday + (daysAfterFirstMayMonday -= (daysAfterFirstMayMonday % 7));
            

            //LABOR DAY (first monday in september)
            int laborDay = FirstSundayOfMonth(year, 9) + 1;
            if (laborDay > 7) { laborDay -= 7; }

            //THANKSGIVING (fourth thursday in november)
            int firstNovemberThursday = FirstSundayOfMonth(year, 11) + 4;
            if (firstNovemberThursday > 7) { firstNovemberThursday -= 7; }
            int thanksgiving = firstNovemberThursday + 21;




            holidays.Add(new DateTime(year, 5, memorialDay));//Memorial Day

            holidays.Add(new DateTime(year, 7, 4));//Independence Day

            holidays.Add(new DateTime(year, 9, laborDay));//Labor Day

            holidays.Add(new DateTime(year, 11, thanksgiving));//Thanksgiving

            holidays.Add(new DateTime(year, 12, 25));//Christmas

            holidays.Add(new DateTime((year + 1), 1, 1));//New Year's


            List<DateTime> actualOffDays = new();

            foreach (var holiday in holidays)
            {
                DateTime actualOffDay = new();
                if (holiday.DayOfWeek == DayOfWeek.Saturday)
                {
                    actualOffDay = holiday.AddDays(-1);
                }
                else if (holiday.DayOfWeek == DayOfWeek.Sunday)
                {
                    actualOffDay = holiday.AddDays(1);
                }
                else { actualOffDay = holiday; }

                actualOffDays.Add(actualOffDay);
            }
            

            return actualOffDays;//these off days include times (all of them are midnight)
        }

        public List<string> holidayNames = new()
        {
            "Memorial Day",
            "Independence Day",
            "Labor Day",
            "Thanksgiving",
            "Christmas",
            "New Year's"
        };
    }
}
