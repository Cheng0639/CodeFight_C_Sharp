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
        public static int[] extractEachKth(int[] inputArray, int k)
        {
            return inputArray.Where((x, i) => (i + 1) % k != 0).ToArray();
        }

        public static void No34_extractEachKth_Run()
        {
            Console.WriteLine(extractEachKth(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3).SequenceEqual(new int[] { 1, 2, 4, 5, 7, 8, 10 }));
            Console.WriteLine(extractEachKth(new int[] { 1, 1, 1, 1, 1 }, 1).SequenceEqual(new int[] { }));
            Console.WriteLine(extractEachKth(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 3).SequenceEqual(new int[] { 1, 1, 1, 1 }));
        }
    }
}