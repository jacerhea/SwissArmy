namespace SwissArmy.Extensions
{
    public static class UlongExtensions
    {
        public static bool IsEven(this ulong value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this ulong value)
        {
            return value % 2 != 0;
        }
    }
}
