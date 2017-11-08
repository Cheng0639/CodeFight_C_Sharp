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
        public static int differentSquares(int[][] matrix)
        {
            return Enumerable.Range(0, matrix.Length - 1).SelectMany(i => Enumerable.Range(0, matrix[i].Length - 1).Select(j => Convert.ToInt32(Enumerable.Range(0, 2).Select(k => Enumerable.Range(0, 2).Select(l => matrix[i + k][j + l].ToString()).Aggregate((a, b) => a + b)).Aggregate((a, b) => a + b)))).Distinct().Count();
        }

        public static void No55_differentSquares_Run()
        {
            Console.WriteLine(differentSquares(
                new int[][]{
                    new int[] { 1, 2, 1 },
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 2, 2 },
                    new int[] { 1, 2, 3 },
                    new int[] { 2, 2, 1 }
                }
            ) == 6);
            Console.WriteLine(differentSquares(
                new int[][]{
                    new int[]{9, 9, 9, 9, 9},
                    new int[]{9, 9, 9, 9, 9},
                    new int[]{9, 9, 9, 9, 9},
                    new int[]{9, 9, 9, 9, 9},
                    new int[]{9, 9, 9, 9, 9},
                    new int[]{9, 9, 9, 9, 9}
                }
            ) == 1);
            Console.WriteLine(differentSquares(new int[][] { new int[] { 3 } }) == 0);
            Console.WriteLine(differentSquares(
                new int[][]{
                    new int[]{3},
                    new int[]{4},
                    new int[]{5},
                    new int[]{6},
                    new int[]{7}
                }
            ) == 0);
            Console.WriteLine(differentSquares(
                new int[][]{
                    new int[]{2, 5, 3, 4, 3, 1, 3, 2},
                    new int[]{4, 5, 4, 1, 2, 4, 1, 3},
                    new int[]{1, 1, 2, 1, 4, 1, 1, 5},
                    new int[]{1, 3, 4, 2, 3, 4, 2, 4},
                    new int[]{1, 5, 5, 2, 1, 3, 1, 1},
                    new int[]{1, 2, 3, 3, 5, 1, 2, 4},
                    new int[]{3, 1, 4, 4, 4, 1, 5, 5},
                    new int[]{5, 1, 3, 3, 1, 5, 3, 5},
                    new int[]{5, 4, 4, 3, 5, 4, 4, 4}
                }
            ) == 54);
            Console.WriteLine(differentSquares(new int[][] { new int[] { 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 2, 3, 9 } }) == 0);
        }
    }
}