using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static bool isInfiniteProcess(int a, int b)
        {
            return a > b || (a - b) % 2 != 0;
        }
    }
}