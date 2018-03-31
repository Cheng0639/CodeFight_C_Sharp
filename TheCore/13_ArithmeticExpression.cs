using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static bool arithmeticExpression(int a, int b, int c)
        {
            return a + b == c
                || a - b == c
                || a * b == c
                || (a / b == c && a % b == 0);
        }
    }
}