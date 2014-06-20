using System;
using System.Collections.Generic;

namespace SwissArmy.Extensions
{
    public static class IListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var random = new Random();
            list.Shuffle(random);
        }

        private static void Shuffle<T>(this IList<T> list, Random random)
        {
            for (int index = list.Count - 1; index > 0; index--)
            {
                int position = random.Next(index + 1);
                T temp = list[index];
                list[index] = list[position];
                list[position] = temp;
            }
        }
    }
}
