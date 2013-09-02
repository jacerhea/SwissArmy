using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<KeyValuePair<string, string>> ToKeyValuePairs(this NameValueCollection collection)
        {
            if (collection == null) { throw new ArgumentNullException("collection"); }
            return collection.Cast<string>().Select(key => new KeyValuePair<string, string>(key, collection[key]));
        }
    }
}
