using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeFights
{
    static partial class Intro
    {
        public static int[][] spiralNumbers(int n)
        {
            int[][] rlt = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();
            int cnt = 1;
            int x = 0;
            int y = 0;
            int dx = 0;
            int dy = 1;
            while (cnt <= (n * n))
            {
                rlt[x][y] = cnt;

                if (dx == 1)
                {
                    if (x == n - 1 || rlt[x + 1][y] != 0)
                    {
                        dx = 0;
                        dy = -1;
                    }
                }
                else if (dx == -1)
                {
                    if (x == 0 || rlt[x - 1][y] != 0)
                    {
                        dx = 0;
                        dy = 1;
                    }
                }
                else if (dy == 1)
                {
                    if (y == n - 1 || rlt[x][y + 1] != 0)
                    {
                        dx = 1;
                        dy = 0;
                    }
                }
                else if (dy == -1)
                {
                    if (y == 0 || rlt[x][y - 1] != 0)
                    {
                        dx = -1;
                        dy = 0;
                    }
                }

                x += dx;
                y += dy;
                cnt++;
            }
            return rlt;
        }

        public static void No59_spiralNumbers_Run()
        {
            Console.WriteLine(spiralNumbers(3).SelectMany(x => x).SequenceEqual(
                new int[][]{
                    new int[]{1, 2, 3},
                    new int[]{8, 9, 4},
                    new int[]{7, 6, 5}
                }.SelectMany(x => x)
            ));
            Console.WriteLine(spiralNumbers(5).SelectMany(x => x).SequenceEqual(
                new int[][]{
                    new int[]{1, 2, 3, 4, 5},
                    new int[]{16, 17, 18, 19, 6},
                    new int[]{15, 24, 25, 20, 7},
                    new int[]{14, 23, 22, 21, 8},
                    new int[]{13, 12, 11, 10, 9}
                }.SelectMany(x => x)
            ));
        }
    }
}