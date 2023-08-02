using System;
using HolidayCalculator;
using Xunit;


namespace OffDayCalculatorTest
{
    public class OffDayCalculator2023Test 
    {
        OffDayCalculator testCase;
        int testYear = 2023; //for later if possible to combine tests

        public OffDayCalculator2023Test()
        {
            //setup the test
            testCase = new OffDayCalculator(testYear);
            testCase.CalculateHolidayOffDays();
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
    public class OffDayCalculator2021Test
    {
        OffDayCalculator testCase;
        int testYear = 2021;//for later if possible to combine tests

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