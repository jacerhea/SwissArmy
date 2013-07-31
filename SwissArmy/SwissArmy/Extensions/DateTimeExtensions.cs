using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmy.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetEarlier(this DateTime dateTime, DateTime datetime2)
        {
            return dateTime >= datetime2 ? datetime2 : dateTime;
        }
    }
}
