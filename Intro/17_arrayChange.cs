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
        public static int arrayChange(int[] inputArray)
        {
            int last = inputArray[0] - 1;
            return inputArray.Sum(_ => (last = Math.Max(last + 1, _)) - _);
        }
        public static void No17_arrayChange_Run()
        {
            Console.WriteLine(arrayChange(new int[] { 1, 1, 1 }) == 3);
            Console.WriteLine(arrayChange(new int[] { -1000, 0, -2, 0 }) == 5);
            Console.WriteLine(arrayChange(new int[] { 2, 1, 10, 1 }) == 12);
        }
    }
}