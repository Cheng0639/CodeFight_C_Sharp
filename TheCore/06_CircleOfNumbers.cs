using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int circleOfNumbers(int n, int firstNumber)
        {
            return (firstNumber + (n / 2)) % n;
        }
    }
}