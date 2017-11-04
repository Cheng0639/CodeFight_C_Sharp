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
        public static string longestDigitsPrefix(string inputString)
        {
            return new string(inputString.TakeWhile(Char.IsDigit).ToArray());
        }

        public static void No40_longestDigitsPrefix_Run()
        {
            Console.WriteLine(longestDigitsPrefix("123aa1") == "123");
            Console.WriteLine(longestDigitsPrefix("0123456789") == "0123456789");
            Console.WriteLine(longestDigitsPrefix("12abc34") == "12");
            Console.WriteLine(longestDigitsPrefix("the output is 42") == "");
        }
    }
}