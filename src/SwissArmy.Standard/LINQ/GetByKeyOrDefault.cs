using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static TK? GetByKeyOrNull<T, TK>(this IDictionary<T, TK> source, T key) where TK : struct
        {
            return source.ContainsKey(key) ? source[key] : default(TK?);
        }

        public static TK? GetByKeyOrNull<T, TK>(this IDictionary<T, TK> source, T? key) where T : struct where TK : struct
        {
            return key.HasValue ? source.ContainsKey(key.Value) ? source[key.Value] : default(TK?) : default(TK?);
        }

        public static TK GetByKeyOrDefault<T, TK>(this IDictionary<T, TK> source, T key)
        {
            return source.ContainsKey(key) ? source[key] : default(TK);
        }

        public static TK GetByKeyOrDefault<T, TK>(this IDictionary<T, TK> source, T? key) where T : struct where TK : struct
        {
            return key.HasValue ? source.ContainsKey(key.Value) ? source[key.Value] : default(TK) : default(TK);
        }
    }
}
