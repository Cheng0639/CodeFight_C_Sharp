using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int mirrorBits(int a)
        {
            return Convert.ToInt32(new String(Convert.ToString(a, 2).Reverse().ToArray()), 2);
        }
        public static int mirrorBits1(int a)
        {
            int result = 0;
            while (a > 0)
            {
                result <<= 1;
                result |= a & 1;
                a >>= 1;
            }

            return result;
        }
    }
}