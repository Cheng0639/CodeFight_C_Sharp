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
        public static int[][] boxBlur(int[][] image)
        {
            return Enumerable.Range(1, image.Length - 2).Select(i => Enumerable.Range(1, image[i].Length - 2).Select(j => (int)Enumerable.Range(-1, 3).SelectMany(a => Enumerable.Range(-1, 3).Select(b => image[i + a][j + b])).Average()).ToArray()).ToArray();
        }
        public static int[][] boxBlur1(int[][] image)
        {
            int[][] rlt = new int[image.Length - 2][];
            for (int i = 1; i < image.Length - 1; i++)
            {
                rlt[i - 1] = new int[image[i].Length - 2];
                for (int j = 1; j < image[i].Length - 1; j++)
                {
                    rlt[i - 1][j - 1] = Convert.ToInt32(
                                        (image[i - 1][j - 1] + image[i - 1][j] + image[i - 1][j + 1]
                                        + image[i][j - 1] + image[i][j] + image[i][j + 1]
                                        + image[i + 1][j - 1] + image[i + 1][j] + image[i + 1][j + 1]
                                        ) / 9
                                     );
                }
            }
            return rlt;
        }

        public static void No23_boxBlur_Run()
        {
            Console.WriteLine(boxBlur(
                new int[][]{
                    new int[]{1, 1, 1}
                    ,new int[]{1, 7, 1}
                    ,new int[]{1, 1, 1}
                }
            ).SequenceEqual(
                new int[][]{
                    new int[]{1}
                }
            ));
            Console.WriteLine(boxBlur(
                new int[][]{
                    new int[]{36, 0, 18, 9}
                    ,new int[]{27, 54, 9, 0}
                    ,new int[]{81, 63, 72, 45}
                }
            ).SequenceEqual(
                new int[][]{
                    new int[]{40, 30}
                }
            ));
            Console.WriteLine(boxBlur(
                new int[][]{
                    new int[]{0, 18, 9}
                    ,new int[]{27, 9, 0}
                    ,new int[]{81, 63, 45}
                }
            ).SequenceEqual(
                new int[][]{
                    new int[]{28}
                }
            ));
            Console.WriteLine(boxBlur(
                new int[][]{
                    new int[]{7, 4, 0, 1}
                    ,new int[]{5, 6, 2, 2}
                    ,new int[]{6, 10, 7, 8}
                    ,new int[] { 1, 4, 2, 0}
                }
            ).SequenceEqual(
               new int[][]{
                   new int[]{5,4}
                   , new int[]{4,4}
               }
            ));
            Console.WriteLine(boxBlur(
                new int[][]{
                    new int[]{36, 0, 18, 9, 9, 45, 27}
                    ,new int[]{27, 0, 54, 9, 0, 63, 90}
                    ,new int[]{81, 63, 72, 45, 18, 27, 0}
                    ,new int[]{0, 0, 9, 81, 27, 18, 45}
                    ,new int[]{45, 45, 27, 27, 90, 81, 72}
                    ,new int[]{45, 18, 9, 0, 9, 18, 45}
                    ,new int[]{27, 81, 36, 63, 63, 72, 81}
                }
            ).SequenceEqual(
                new int[][]{
                    new int[]{39, 30, 26, 25, 31}
                    ,new int[]{34, 37, 35, 32, 32}
                    ,new int[]{38, 41, 44, 46, 42}
                    ,new int[]{22, 24, 31, 39, 45}
                    ,new int[]{37, 34, 36, 47, 59}
                }
            ));
        }
    }
}