using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int[] metroCard(int lastNumberOfDays)
        {
            return lastNumberOfDays == 31
                ? new int[] { 28, 30, 31 }
                : new int[] { 31 };
        }
    }
}