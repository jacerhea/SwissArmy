namespace SwissArmy.Extensions
{
    public static class LongExtensions
    {
        public static bool IsEven(this long value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this long value)
        {
            return value % 2 != 0;
        }

        public static bool IsDivisibleBy(this long value, int divisor)
        {
            return value % divisor == 0;
        }

        public static bool IsDivisibleBy(this long value, long divisor)
        {
            return value % divisor == 0;
        }
    }
}
