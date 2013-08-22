using System;

namespace SwissArmy.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetEarlier(this DateTime dateTime, DateTime datetime2)
        {
            return dateTime >= datetime2 ? datetime2 : dateTime;
        }

        public static DateTime NextDay(this DateTime date, DayOfWeek dayOfWeek)
        {
            
        }
    }
}
