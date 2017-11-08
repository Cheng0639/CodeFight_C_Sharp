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
        public static string longestWord(string text)
        {
            return Regex.Split(text, @"\W+").OrderByDescending(x => x.Length).First();
        }

        public static void No52_longestWord_Run()
        {
            Console.WriteLine(longestWord("Ready, steady, go!") == "steady");
            Console.WriteLine(longestWord("Ready[[[, steady, go!") == "steady");
            Console.WriteLine(longestWord("ABCd") == "ABCd");
        }
    }
}