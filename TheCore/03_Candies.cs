using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int candies(int n, int m)
        {
            return m - m % n;
        }
    }
}