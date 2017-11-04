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
        public static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (maxW >= weight1 + weight2)
            {
                return value1 + value2;
            }
            else if (maxW >= weight1 && maxW >= weight2)
            {
                return Math.Max(value1, value2);
            }
            else if (maxW < weight1 && maxW >= weight2)
            {
                return value2;
            }
            else if (maxW < weight2 && maxW >= weight1)
            {
                return value1;
            }
            else
            {
                return 0;
            }
        }

        public static void No39_knapsackLight_Run()
        {
            Console.WriteLine(knapsackLight(10, 5, 6, 4, 8) == 10);
            Console.WriteLine(knapsackLight(10, 5, 6, 4, 9) == 16);
            Console.WriteLine(knapsackLight(5, 3, 7, 4, 6) == 7);
            Console.WriteLine(knapsackLight(10, 2, 11, 3, 1) == 0);
        }
    }
}