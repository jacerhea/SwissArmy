using System;

namespace SwissArmy.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetEarlier(this DateTime dateTime, DateTime datetime2)
        {
            return dateTime >= datetime2 ? datetime2 : dateTime;
        }

        public static bool IsWeekend(this DateTime datetime)
        {
            return datetime.DayOfWeek == DayOfWeek.Saturday || datetime.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWeekend(this DateTimeOffset datetime)
        {
            return IsWeekend(datetime.DateTime);
        }

        //public static DateTime Next(this DateTime date, DayOfWeek dayOfWeek)
        //{
        //    return date.AddDays(date.DayOfWeek)
        //}
    }
}
