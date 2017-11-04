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
        public static int absoluteValuesSumMinimization(int[] a)
        {
            return a[(a.Length-1)/2]; 
        }


        public static void No32_absoluteValuesSumMinimization_Run()
        {
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { 1, 1, 3, 4 }) == 1);
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { 23}) == 23);
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { -10, -10, -10, -10, -10, -9, -9, -9, -8, -8, -7, -6, -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}) == 15);
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { -4, -1}) == -4);
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { -1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000}) == 0);
        }
    }
}