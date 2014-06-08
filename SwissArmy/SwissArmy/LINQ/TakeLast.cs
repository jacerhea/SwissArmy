﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> enumerable, int count)
        {
            return enumerable.Reverse().Take(count);
        }
    }
}
