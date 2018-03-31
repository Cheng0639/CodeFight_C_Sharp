using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int rangeBitCount(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).Aggregate(0, (t, n) => t += Convert.ToString(n, 2).Count(x => x == '1'));
        }

        public static int rangeBitCount1(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).Select(
                x =>
                {
                    int count = 0;
                    int tmp = x;
                    while (tmp > 0)
                    {
                        count += tmp & 1;
                        tmp = tmp >> 1;
                    }
                    return count;
                }
            ).Sum();
        }

        public static int rangeBitCount2(int a, int b)
        {
            var total = 0;
            for (int i = a; i <= b; i++)
            {
                int s = i;
                while (s > 0)
                {
                    total += s & 1;
                    s = s >> 1;
                }
            }

            return total;
        }
    }
}