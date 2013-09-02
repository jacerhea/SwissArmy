﻿using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class     
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return new HashSet<T>(source);
        }
    }
}