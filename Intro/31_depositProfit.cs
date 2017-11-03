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
        public static int depositProfit(int deposit, int rate, int threshold)
        {
            return (int)Math.Ceiling(Math.Log(threshold * 1.0 / deposit, 1 + (rate / 100.0)));
        }

        public static int depositProfit1(int deposit, int rate, int threshold)
        {
            int year = 0;
            double cnt = deposit;
            double Q = rate / 100.0 + 1;
            while (cnt < threshold)
            {
                cnt = cnt * Q;
                year++;
            }
            return year;
        }

        public static void No31_depositProfit_Run()
        {
            Console.WriteLine(depositProfit(120, 20, 170) == 3);
            Console.WriteLine(depositProfit(100, 1, 101) == 1);
            Console.WriteLine(depositProfit(1, 100, 64) == 6);
        }
    }
}