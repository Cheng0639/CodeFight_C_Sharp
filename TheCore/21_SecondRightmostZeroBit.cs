using System;
using System.Linq;

namespace CodeFights
{
    public partial class TheCore
    {
        int secondRightmostZeroBit(int n)
        {
            return (n | (n + 1)) ^ ((n | (n + 1)) | ((n | (n + 1)) + 1));
        }
    }
}