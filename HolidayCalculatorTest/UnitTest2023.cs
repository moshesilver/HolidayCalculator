using System;
using HolidayCalculator;
using Microsoft.VisualBasic;
using Xunit;


namespace HolidayCalculatorTest
{
    public class HolidayCalculatorTest 
    {
        OffDayCalculator testCase;
        int testYear = 2023; //for later if possible to combine tests

        public HolidayCalculatorTest()
        {
            //setup the test
            testCase = new OffDayCalculator(testYear);
            testCase.CalculateHolidayOffDays(testCase.Year);
        }

        [Fact]
        public void TestMemorialOffDay()
        {
            //Arrange
            DateTime expected = new (testYear, 5, 29);
            //Act
            DateTime actual = testCase.MemorialOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestIndependenceOffDay()
        {
            //Arange
            DateTime expected = new (testYear, 7, 4);
            //Act
            DateTime actual = testCase.IndependenceOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestLaborOffDay()
        {
            //Arange
            DateTime expected = new (testYear, 9, 4);
            //Act
            DateTime actual = testCase.LaborOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestThanksgivingOffDay()
        {
            //Arange
            DateTime expected = new(testYear, 11,23);
            //Act
            DateTime actual = testCase.ThanksgivingOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestChristmasOffDay()
        {
            //Arange
            DateTime expected = new(testYear, 12, 25);
            //Act
            DateTime actual = testCase.ChristmasOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNewYearsOffDay()
        {
            //Arange
            DateTime expected = new(testYear + 1, 1, 1);
            //Act
            DateTime actual = testCase.NewYearsOffDay;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}