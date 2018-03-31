using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int maxMultiple(int divisor, int bound)
        {
            return bound / divisor * divisor;
        }
    }
}