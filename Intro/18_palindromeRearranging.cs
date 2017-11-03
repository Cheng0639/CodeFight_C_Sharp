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
        public static bool palindromeRearranging(string inputString)
        {
            return inputString.GroupBy(x => x).Where(x => x.Count() % 2 == 1).Count() < 2;
        }

        public static void No18_palindromeRearranging_Run()
        {

            Console.WriteLine(arrayChange(new int[] { 1, 1, 1 }) == 3);
            Console.WriteLine(arrayChange(new int[] { -1000, 0, -2, 0 }) == 5);
            Console.WriteLine(arrayChange(new int[] { 2, 1, 10, 1 }) == 12);
        }
    }
}