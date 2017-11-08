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
        public static string buildPalindrome(string st)
        {
            string reverse = new string(st.Reverse().ToArray());
            int count = reverse.Length;

            while (st.LastIndexOf(reverse.Substring(0, count)) < 0)
            {
                count--;
            }

            return st.Substring(0, st.LastIndexOf(reverse.Substring(0, count))) + reverse;
        }

        public static void No45_buildPalindrome_Run()
        {
            Console.WriteLine(buildPalindrome("abcdc") == "abcdcba");
            Console.WriteLine(buildPalindrome("ababab") == "abababa");
            Console.WriteLine(buildPalindrome("abba") == "abba");
            Console.WriteLine(buildPalindrome("abaa") == "abaaba");
        }
    }
}