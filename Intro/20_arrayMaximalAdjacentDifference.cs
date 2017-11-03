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
        public static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int last = inputArray[0];
            return inputArray.Skip(1).Max(x => Math.Abs(last - (last = x)));
        }

        public static void No20_arrayMaximalAdjacentDifference_Run()
        {
            Console.WriteLine(arrayMaximalAdjacentDifference(new int[] { 2, 4, 1, 0 }) == 3);
            Console.WriteLine(arrayMaximalAdjacentDifference(new int[] { 1, 1, 1, 1 }) == 0);
            Console.WriteLine(arrayMaximalAdjacentDifference(new int[] { -1, 4, 10, 3, -2 }) == 7);
        }
    }
}