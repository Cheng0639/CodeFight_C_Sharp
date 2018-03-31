using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int lateRide(int n)
        {
            return n / 600 + n / 60 % 10 + n % 60 / 10 + n % 60 % 10;
        }
    }
}