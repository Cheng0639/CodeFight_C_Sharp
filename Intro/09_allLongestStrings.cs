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
        public static string[] allLongestStrings(string[] inputArray)
        {
            int max = inputArray.Max(x => x.Length);
            return inputArray.Where(x => x.Length == max).ToArray();
        }
        public static void No9_allLongestStrings_Run()
        {
            Console.WriteLine(allLongestStrings(new string[] { "aba", "aa", "ad", "vcd", "aba" }).SequenceEqual(new string[] { "aba", "vcd", "aba" }));
            Console.WriteLine(allLongestStrings(new string[] { "a", "abc", "cbd", "zzzzzz", "a", "abcdef", "asasa", "aaaaaa" }).SequenceEqual(new string[] { "zzzzzz", "abcdef", "aaaaaa" }));
        }
    }
}