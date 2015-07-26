using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static int Product(this IEnumerable<int> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Aggregate(1, (i, i1) => i*i1);
        }

        public static decimal Product(this IEnumerable<decimal> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Aggregate(1m, (i, i1) => i * i1);
        }

        public static double Product(this IEnumerable<double> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Aggregate(1d, (i, i1) => i * i1);
        }

        public static long Product(this IEnumerable<long> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Aggregate(1L, (i, i1) => i * i1);
        }

        public static float Product(this IEnumerable<float> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Aggregate(1F, (i, i1) => i * i1);
        }
    }
}
