using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int largestNumber(int n)
        {
            return Convert.ToInt32(Math.Pow(10, n)) - 1;
        }
    }
}