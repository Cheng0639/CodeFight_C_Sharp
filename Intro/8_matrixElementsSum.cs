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
        public static int matrixElementsSum(int[][] matrix)
        {
            int r = 0;
            for (int i = 0; i < matrix[0].Length; i++)
                for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                    r += matrix[j][i];

            return r;
        }

        public static void No8_matrixElementsSum_Run()
        {
            Console.WriteLine(matrixElementsSum(
                new int[][] {
                    new int[]{0, 1, 1, 2},
                    new int[]{0, 5, 0, 0},
                    new int[]{2, 0, 3, 3}
                }
            ) == 9);
            Console.WriteLine(matrixElementsSum(
                new int[][] {
                    new int[]{1, 1, 1, 0 },
                    new int[]{0,5,0,1},
                    new int[]{2, 1, 3, 10 }
                }
            ) == 9);
            Console.WriteLine(matrixElementsSum(
                new int[][] {
                    new int[]{1, 1, 1 },
                    new int[]{2,2,2},
                    new int[]{3,3,3}
                }
            ) == 18);
        }
    }
}