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
    public static class Extension
    {
    }
    static partial class Intro
    {
        public static bool stringsRearrangement(string[] r)
        {
            return r.Any(_ => S(r, _));
        }

        public static bool S(string[] r, string s)
        {
            return !r.Any() | r.Where((_, i) => _.Where((c, j) => c != s[j]).Count() == 1 && S(r.Where((o, j) => i != j).ToArray(), _)).Any();
        }
        public static void No33_stringsRearrangement_Run()
        {
            Console.WriteLine(stringsRearrangement(new string[] { "abc", "bef", "bcc", "bec", "bbc", "bdc" }) == true);
            Console.WriteLine(stringsRearrangement(new string[] { "abc", "abx", "axx", "abc" }) == false);
            Console.WriteLine(stringsRearrangement(new string[] { "zzzzab", "zzzzbb", "zzzzaa" }) == true);
        }
    }
}