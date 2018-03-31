using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int arrayPacking(int[] a)
        {
            return a.Reverse().Aggregate((x, y) => (x << 8) + y);
        }
    }
}