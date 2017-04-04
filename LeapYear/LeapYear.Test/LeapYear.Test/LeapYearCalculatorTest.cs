using System;
using Xunit;

namespace LeapYear.Test
{
    public class LeapYearCalculatorTest
    {

        private ILeapYearCalculator _leapYearCalculator;

        public LeapYearCalculatorTest()
        {
            _leapYearCalculator = new LeapYearCalculator();
        }
        

       [Theory,
        InlineData(1900, false),
        InlineData(1910, false),
        InlineData(2000, true),
        InlineData(2001, false)]
        public void InlineDataExample(long year, bool expectedResult)
        {
            Assert.Equal(expectedResult, _leapYearCalculator.IsLeapYear(year));
        }
    }
}
