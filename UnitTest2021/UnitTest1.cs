using System;
using Xunit;
using HolidayCalculator;


namespace OffDayCalculatorTest
{
    public class OffDayCalculator2021Test
    {
        OffDayCalculator testCase;
        int testYear = 2021;//in case of later combining with other tests

        public OffDayCalculator2021Test()
        {
            testCase = new OffDayCalculator(testYear);
            testCase.CalculateHolidayOffDays();
        }

        [Fact]
        public void TestMemorialOffDay()
        {
            DateTime expected = new(testYear, 5, 31);
            DateTime actual = testCase.MemorialOffDay;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestIndependenceOffDay()
        {
            DateTime expected = new(testYear, 7, 5);
            DateTime actual = testCase.IndependenceOffDay;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestLaborOffDay()
        {
            DateTime expected = new(testYear, 9, 6);
            DateTime actual = testCase.LaborOffDay;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestThanksgivingOffDay()
        {
            DateTime expected = new(testYear, 11, 25);
            DateTime actual = testCase.ThanksgivingOffDay;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestChristmasOffDay()
        {
            DateTime expected = new(testYear, 12, 24);
            DateTime actual = testCase.ChristmasOffDay;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNewYearsOffDay()
        {
            DateTime expected = new(testYear, 12, 31);
            DateTime actual = testCase.NewYearsOffDay;
            Assert.Equal(expected, actual);
        }
    }
}