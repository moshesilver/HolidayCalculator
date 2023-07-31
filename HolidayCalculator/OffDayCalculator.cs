using System;

namespace HolidayCalculator
{
    public class OffDayCalculator
    {
        public OffDayCalculator(int Year)
        {
            this.Year = Year;
        }
        public int Year { get; set; }


        private DateTime independenceOffDay;
        private DateTime christmasOffDay;
        private DateTime newYearsOffDay;


        public DateTime MemorialOffDay { get; private set; }
        public DateTime IndependenceOffDay
        {
            get { return independenceOffDay; }
            private set { independenceOffDay = ActualOffDay(value); }
        }
        public DateTime LaborOffDay { get; private set; }
        public DateTime ThanksgivingOffDay { get; private set; }
        public DateTime ChristmasOffDay
        {
            get { return christmasOffDay; }
            private set { christmasOffDay = ActualOffDay(value); }
        }
        public DateTime NewYearsOffDay
        {
            get { return newYearsOffDay; }
            private set { newYearsOffDay = ActualOffDay(value); }
        }


        public DateTime ActualOffDay(DateTime holiday)
        {
            return holiday.DayOfWeek switch
            {
                DayOfWeek.Saturday => holiday.AddDays(-1),
                DayOfWeek.Sunday => holiday.AddDays(1),
                _ => holiday,
            };
        }
        public int FirstSundayOfMonth(int month)
        {
            DateTime day1 = new(Year, month, 1);
            int firstSundayOfMonth = ((7 - Convert.ToInt32(day1.DayOfWeek)) + 1);
            if (firstSundayOfMonth >= 7) { firstSundayOfMonth -= 7; }
            return firstSundayOfMonth;
        }
        public List<DateTime> CalculateHolidayOffDays()
        {
            List<DateTime> holidayOffDays = new();

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
            int firstMayMonday = FirstSundayOfMonth(5) + 1;
            int daysAfterFirstMayMonday = 31 - firstMayMonday;
            int memorialDay = firstMayMonday + (daysAfterFirstMayMonday -= (daysAfterFirstMayMonday % 7));


            //LABOR DAY (first monday in september)
            int laborDay = FirstSundayOfMonth(9) + 1;
            if (laborDay > 7) { laborDay -= 7; }

            //THANKSGIVING (fourth thursday in november)
            int firstNovemberThursday = FirstSundayOfMonth(11) + 4;
            if (firstNovemberThursday > 7) { firstNovemberThursday -= 7; }
            int thanksgiving = firstNovemberThursday + 21;


            MemorialOffDay = new DateTime(Year, 5, memorialDay);
            IndependenceOffDay = new DateTime(Year, 7, 4);
            LaborOffDay = new DateTime(Year, 9, laborDay);
            ThanksgivingOffDay = new DateTime(Year, 11, thanksgiving);
            ChristmasOffDay = new DateTime(Year, 12, 25);
            NewYearsOffDay = new DateTime((Year + 1), 1, 1);


            holidayOffDays.Add(MemorialOffDay);//Memorial Day

            holidayOffDays.Add(IndependenceOffDay);//Independence Day

            holidayOffDays.Add(LaborOffDay);//Labor Day

            holidayOffDays.Add(ThanksgivingOffDay);//Thanksgiving

            holidayOffDays.Add(ChristmasOffDay);//Christmas

            holidayOffDays.Add(NewYearsOffDay);//New Year's




            return holidayOffDays;//these off days include times (all of them are midnight)
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
