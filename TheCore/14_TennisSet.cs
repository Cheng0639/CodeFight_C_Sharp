using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static bool tennisSet(int score1, int score2)
        {
            return score1 != score2
                && ((Math.Max(score1, score2) == 6 && score1 + score2 < 11)
                    || (Math.Min(score1, score2) >= 5 && Math.Max(score1, score2) == 7)
                );
        }
    }
}