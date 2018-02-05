using System;

namespace SwissArmy.Extensions
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            if (value == null)
            { throw new ArgumentNullException(nameof(value), "substring cannot be null."); }
            if (!Enum.IsDefined(typeof(StringComparison), comparisonType))
            { throw new ArgumentException("comp is not a member of StringComparison", nameof(comparisonType)); }

            return source.IndexOf(value, comparisonType) >= 0;
        }

        public static string TruncateWithEllipsis(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength) + "…";
        }

        public static string AddIfMissing(this string value, string toAdd, StringComparison comparisonType = StringComparison.CurrentCultureIgnoreCase)
        {
            if (value == null)
            { throw new ArgumentNullException(nameof(value), "substring cannot be null."); }
            if (toAdd == null)
            { throw new ArgumentNullException(nameof(toAdd), "substring cannot be null."); }
            if (!Enum.IsDefined(typeof(StringComparison), comparisonType))
            { throw new ArgumentException("comp is not a member of StringComparison", nameof(comparisonType)); }

            return value.Contains(toAdd, comparisonType) ?
                value
                : value + toAdd;
        }

        public static string Replace(this string source, string oldValue, string newValue, StringComparison comparisonType)
        {
            if (oldValue == null)
            { throw new ArgumentNullException(nameof(oldValue), "substring cannot be null."); }
            if (newValue == null)
            { throw new ArgumentNullException(nameof(oldValue), "substring cannot be null."); }
            if (!Enum.IsDefined(typeof(StringComparison), comparisonType))
            { throw new ArgumentException("comp is not a member of StringComparison", nameof(comparisonType)); }

            var index = source.IndexOf(oldValue, comparisonType);
            if (index > -1)
            {
                var removed = source.Remove(index, oldValue.Length);
                return removed.Insert(index, newValue);
            }
            return source;
        }

        public static string ToTitleCase(this string str)
        {
            var tokens = str.Split(new[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];
                tokens[i] = token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
            }

            return string.Join(" ", tokens);
        }
    }
}
