using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int addTwoDigits(int n)
        {
            return n.ToString().Sum(x => Convert.ToInt32(x.ToString()));
        }
    }
}