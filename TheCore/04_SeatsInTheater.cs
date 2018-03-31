using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        public static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return ((nCols - col + 1) * (nRows - row));
        }
    }
}