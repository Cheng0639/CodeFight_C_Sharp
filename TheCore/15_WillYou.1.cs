using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static bool willYou(bool young, bool beautiful, bool loved)
        {
            return (young && beautiful) != loved;
        }
    }
}