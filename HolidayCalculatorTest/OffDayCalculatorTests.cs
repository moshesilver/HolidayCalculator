using System;
using HolidayCalculator;
using Xunit;


namespace OffDayCalculatorTest
{
    public class CalculateHolidayOffDaysTest
    {
        OffDayCalculator testCase2023;
        OffDayCalculator testCase2021;

        public CalculateHolidayOffDaysTest()
        {
            //setup the test
            testCase2023 = new OffDayCalculator(2023);
            testCase2023.CalculateHolidayOffDays();
            testCase2021 = new OffDayCalculator(2021);
            testCase2021.CalculateHolidayOffDays();
        }

        [Fact]
        public void TestMemorialOffDay()
        {
            //Arrange
            DateTime expected23 = new(2023, 5, 29);
            DateTime expected21 = new(2021, 5, 31);
            //Act
            DateTime actual23 = testCase2023.MemorialOffDay;
            DateTime actual21 = testCase2021.MemorialOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
        [Fact]
        public void TestIndependenceOffDay()
        {
            //Arange
            DateTime expected23 = new(2023, 7, 4);
            DateTime expected21 = new(2021, 7, 5);
            //Act
            DateTime actual23 = testCase2023.IndependenceOffDay;
            DateTime actual21 = testCase2021.IndependenceOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
        [Fact]
        public void TestLaborOffDay()
        {
            //Arange
            DateTime expected23 = new(2023, 9, 4);
            DateTime expected21 = new(2021, 9, 6);
            //Act
            DateTime actual23 = testCase2023.LaborOffDay;
            DateTime actual21 = testCase2021.LaborOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
        [Fact]
        public void TestThanksgivingOffDay()
        {
            //Arange
            DateTime expected23 = new(2023, 11, 23);
            DateTime expected21 = new(2021, 11, 25);
            //Act
            DateTime actual23 = testCase2023.ThanksgivingOffDay;
            DateTime actual21 = testCase2021.ThanksgivingOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
        [Fact]
        public void TestChristmasOffDay()
        {
            //Arange
            DateTime expected23 = new(2023, 12, 25);
            DateTime expected21 = new(2021, 12, 24);
            //Act
            DateTime actual23 = testCase2023.ChristmasOffDay;
            DateTime actual21 = testCase2021.ChristmasOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
        [Fact]
        public void TestNewYearsOffDay()
        {
            //Arange
            DateTime expected23 = new(2024, 1, 1);
            DateTime expected21 = new(2021, 12, 31);
            //Act
            DateTime actual23 = testCase2023.NewYearsOffDay;
            DateTime actual21 = testCase2021.NewYearsOffDay;
            //Assert
            Assert.Equal(expected23, actual23);
            Assert.Equal(expected21, actual21);
        }
    }
}