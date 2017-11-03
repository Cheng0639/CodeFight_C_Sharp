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
        public static int avoidObstacles(int[] inputArray)
        {
            int rlt = 2;
            while (inputArray.Any(x => x % rlt == 0))
            {
                rlt++;
            }
            return rlt;
        }

        public static void No22_avoidObstacles_Run()
        {
            Console.WriteLine(avoidObstacles(new int[] { 5, 3, 6, 7, 9 }) == 4);
            Console.WriteLine(avoidObstacles(new int[] { 2, 3 }) == 4);
            Console.WriteLine(avoidObstacles(new int[] { 1, 4, 10, 6, 2 }) == 4);
        }
    }
}