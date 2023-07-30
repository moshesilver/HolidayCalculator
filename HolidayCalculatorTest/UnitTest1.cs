using System;
using HolidayCalculator;
using Microsoft.VisualBasic;
using Xunit;


namespace HolidayCalculatorTest
{
    public class HolidayCalculatorTest
    {
        HolidayCalculator.HolidayCalculator testYear;
        public HolidayCalculatorTest()
        {
            testYear = new HolidayCalculator.HolidayCalculator(2023);
            
        }


        [Fact]
        public void TestMemorialDayCalculator()
        {
            //arrange
            DateTime expected = new DateTime(2023, 5, 29);
            //act

            //assert

        }
    }
}