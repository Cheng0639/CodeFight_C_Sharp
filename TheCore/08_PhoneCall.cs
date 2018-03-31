using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int phoneCall(int min1, int min2_10, int min11, int s)
        {
            if (s < min1)
            {
                return 0;
            }
            else if (s < min1 + min2_10 * 9)
            {
                return (s - min1) / min2_10 + 1;
            }
            else
            {
                return (s - min1 - min2_10 * 9) / min11 + 10;
            }
        }
    }
}