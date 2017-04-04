using System;

namespace LeapYear
{
    public class LeapYearCalculator: ILeapYearCalculator
    {
        public bool IsLeapYear(long year)
        {
            if((year % 4 == 0 && year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                    return true;
            }

            return false;
        }
    }
}
