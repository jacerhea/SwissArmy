using System;

namespace SwissArmy.Extensions
{
    public static class StringExtensions
    {
        public static bool Contains(this string str, string substring, StringComparison comp)
        {
            if (str == null)
            {
                return false;
            }
            if (substring == null)
                throw new ArgumentNullException(nameof(substring), "substring cannot be null.");
            if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison", nameof(comp));

            return str.IndexOf(substring, comp) >= 0;
        }
    }
}
