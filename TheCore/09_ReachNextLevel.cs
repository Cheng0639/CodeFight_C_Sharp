using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }
    }
}