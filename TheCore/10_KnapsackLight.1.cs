using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            return maxW >= weight1 + weight2
                ? value1 + value2
                : Math.Max(maxW >= weight1 ? value1 : 0, maxW >= weight2 ? value2 : 0);
        }
    }
}