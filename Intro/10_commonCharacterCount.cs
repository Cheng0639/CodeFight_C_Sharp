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
        public static int commonCharacterCount(string s1, string s2)
        {
            return s1.Distinct().Sum(_ => Math.Min(s1.Count(l => l == _), s2.Count(l => l == _)));
        }

        public static void No10_commonCharacterCount_Run()
        {
            Console.WriteLine(commonCharacterCount("aabcc", "adcaa") == 3);
            Console.WriteLine(commonCharacterCount("zzzz", "zzzzzzz") == 4);
            Console.WriteLine(commonCharacterCount("abca", "xyzbac") == 3);
        }
    }
}