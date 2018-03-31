using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int extraNumber(int a, int b, int c)
        {
            // Same number will let all bit to 0 so when nor different number
            // all different number's bit will not change
            return a ^ b ^ c;
        }
    }
}