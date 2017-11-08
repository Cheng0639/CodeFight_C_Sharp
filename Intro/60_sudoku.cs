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
        public static bool sudoku(int[][] grid)
        {
            var checkLine = grid.All(x => x.Distinct().Count() == 9);
            var checkCol = Enumerable.Range(0, grid.Length).Select(x => Enumerable.Range(0, grid.Length).Select(y => grid[y][x])).Any(x => x.Distinct().Count() == 9);
            var checkMatrix = Enumerable.Range(0, grid.Length / 3).SelectMany(x => Enumerable.Range(0, grid.Length / 3).Select(y => Enumerable.Range(0, 3).SelectMany(a => Enumerable.Range(0, 3).Select(b => grid[3 * x + a][3 * y + b]))).Select(_ => _.Distinct().Count() == 9)).All(x => x);
            var tmp = Enumerable.Range(0, grid.Length / 3).Select(x => Enumerable.Range(0, grid.Length / 3).Select(y => Enumerable.Range(0, 3).SelectMany(a => Enumerable.Range(0, 3).Select(b => grid[3 * x + a][3 * y + b])).ToArray()).ToArray()).ToArray();
            return checkLine && checkCol & checkMatrix;
        }

        public static void No60_sudoku_Run()
        {
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 3, 2, 5, 4, 6, 9, 8, 7},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{9, 2, 1, 4, 3, 5, 8, 7, 6},
                    new int[]{3, 5, 4, 7, 6, 8, 2, 1, 9},
                    new int[]{6, 8, 7, 1, 9, 2, 5, 4, 3},
                    new int[]{5, 7, 6, 9, 8, 1, 4, 3, 2},
                    new int[]{2, 4, 3, 6, 5, 7, 1, 9, 8},
                    new int[]{8, 1, 9, 3, 2, 4, 7, 6, 5}
                }
            ) == true);
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 3, 2, 5, 4, 6, 9, 2, 7},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 8, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{9, 2, 1, 4, 3, 5, 8, 7, 6},
                    new int[]{3, 5, 4, 7, 6, 8, 2, 1, 9},
                    new int[]{6, 8, 7, 1, 9, 2, 5, 4, 3},
                    new int[]{5, 7, 6, 9, 8, 1, 4, 3, 2},
                    new int[]{2, 4, 3, 6, 5, 7, 1, 9, 8},
                    new int[]{8, 1, 9, 3, 2, 4, 7, 6, 5}
                }
            ) == false);
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 3, 4, 2, 5, 6, 9, 8, 7},
                    new int[]{4, 6, 8, 5, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 2, 8, 1, 3, 6, 5, 4},
                    new int[]{9, 2, 3, 1, 4, 5, 8, 7, 6},
                    new int[]{3, 5, 7, 4, 6, 8, 2, 1, 9},
                    new int[]{6, 8, 1, 7, 9, 2, 5, 4, 3},
                    new int[]{5, 7, 6, 9, 8, 1, 4, 3, 2},
                    new int[]{2, 4, 5, 6, 3, 7, 1, 9, 8},
                    new int[]{8, 1, 9, 3, 2, 4, 7, 6, 5}
                }
            ) == false);
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 3, 2, 5, 4, 6, 9, 8, 7},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{9, 2, 1, 4, 3, 5, 8, 7, 6},
                    new int[]{3, 5, 4, 7, 6, 8, 2, 1, 9},
                    new int[]{6, 8, 7, 1, 9, 2, 5, 4, 3},
                    new int[]{5, 4, 6, 9, 8, 1, 4, 3, 2},
                    new int[]{2, 7, 3, 6, 5, 7, 1, 9, 8},
                    new int[]{8, 1, 9, 3, 2, 4, 7, 6, 5}
                }
            ) == false);
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4}
                }
            ) == false);
            Console.WriteLine(sudoku(
                new int[][]{
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4},
                    new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[]{4, 6, 5, 8, 7, 9, 3, 2, 1},
                    new int[]{7, 9, 8, 2, 1, 3, 6, 5, 4}
                }
            ) == false);
        }
    }
}