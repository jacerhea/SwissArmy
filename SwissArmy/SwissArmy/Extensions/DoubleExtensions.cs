using System;

namespace SwissArmy.Extensions
{
    public static class DoubleExtensions
    {
        public static bool HasFractionalValue(this double d)
        {
            // If there is a remainder when dividing by one, then the number has a fractional value
            return d % 1D != 0D;
        }

        /// <summary>
        /// Is the date today's date?
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>

        public static bool IsSameDate(this DateTime date, DateTime date2)
        {
            return date.Date == date2.Date;
        } 
    }
}
