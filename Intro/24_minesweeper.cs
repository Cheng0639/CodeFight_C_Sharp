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
        public static int[][] minesweeper(bool[][] matrix)
        {
            return Enumerable.Range(0, matrix.Length)
                                .Select(i =>
                                    Enumerable.Range(0, matrix[i].Length)
                                    .Select(
                                        j => Enumerable.Range(start: (i == 0) ? 0 : -1, count: (i == 0 || i == matrix.Length - 1 ? 2 : 3))
                                                        .SelectMany(
                                                            a => Enumerable.Range(start: (j == 0) ? 0 : -1, count: (j == 0 || j == matrix[i].Length - 1 ? 2 : 3))
                                                                            .Select(b => matrix[i + a][j + b] ? 1 : 0)
                                                        ).Sum() - (matrix[i][j] ? 1 : 0)
                                    ).ToArray()
                                ).ToArray();
        }

        public static int[][] minesweeper1(bool[][] matrix)
        {
            return matrix
                .Select((_, i) =>
                        _.Select((c, j) =>
                                 matrix.Skip(i - 1)
                                 .Take(i < 1 || i == matrix.Length - 1 ? 2 : 3)
                                 .SelectMany(r =>
                                             r.Skip(j - 1)
                                             .Take(j < 1 || j == _.Length - 1 ? 2 : 3))
                                 .Count(m => m == true) - (matrix[i][j] ? 1 : 0))
                        .ToArray())
                .ToArray();
        }
        public static void No24_minesweeper_Run()
        {
            Console.WriteLine(minesweeper(
                new bool[][]{
                     new bool[]{true, false, false}
                    ,new bool[]{false, true, false}
                    ,new bool[]{false, false, false}
                }
            )
            .SelectMany(x => x)
            .SequenceEqual(
                new int[][]{
                     new int[]{1, 2, 1}
                    ,new int[]{2, 1, 1}
                    ,new int[]{1, 1, 1}
                }.SelectMany(x => x)
            ));
            Console.WriteLine(minesweeper(
                new bool[][]{
                      new bool[]{false, false, false}
                    , new bool[]{false, false, false}
                }
            )
            .SelectMany(x => x)
            .SequenceEqual(
                new int[][]{
                       new int[]{ 0 , 0 , 0 }
                     , new int[]{ 0 , 0 , 0 }
                }.SelectMany(x => x)
            ));
            Console.WriteLine(minesweeper(
                new bool[][]{
                     new bool[]{true, false, false, true}
                    ,new bool[]{false, false, true, false}
                    ,new bool[]{true, true, false, true}
                }
            )
            .SelectMany(x => x)
            .SequenceEqual(
                new int[][]{
                     new int[]{0, 2, 2, 1}
                    ,new int[]{3, 4, 3, 3}
                    ,new int[]{1, 2, 3, 1}
                }.SelectMany(x => x)
            ));
        }
    }
}