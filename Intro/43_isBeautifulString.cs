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
        public static bool isBeautifulString(string inputString)
        {
            var cnt = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => inputString.Count(y => y == x));
            return cnt.SequenceEqual(cnt.OrderByDescending(x => x));
        }

        public static void No43_isBeautifulString_Run()
        {
            Console.WriteLine(isBeautifulString("bbbaacdafe") == true);
            Console.WriteLine(isBeautifulString("aabbb") == false);
            Console.WriteLine(isBeautifulString("bbc") == false);
            Console.WriteLine(isBeautifulString("bbbaa") == false);
            Console.WriteLine(isBeautifulString("abcdefghijklmnopqrstuvwxyzz") == false);
            Console.WriteLine(isBeautifulString("abcdefghijklmnopqrstuvwxyz") == true);
            Console.WriteLine(isBeautifulString("zaa") == false);
        }
    }
}