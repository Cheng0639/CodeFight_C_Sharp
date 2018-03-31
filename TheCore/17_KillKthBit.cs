using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int killKthBit(int n, int k)
        {
            return n & ~(1 << k - 1);
        }
    }
}