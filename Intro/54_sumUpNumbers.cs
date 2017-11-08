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
        public static int sumUpNumbers(string inputString)
        {
            return Regex.Matches(inputString, @"\d+").Cast<Match>().Sum(x => int.Parse(x.Value));
        }

        public static void No54_sumUpNumbers_Run()
        {
            Console.WriteLine(sumUpNumbers("2 apples, 12 oranges") == 14);
            Console.WriteLine(sumUpNumbers("123450") == 123450);
            Console.WriteLine(sumUpNumbers("Your payment method is invalid") == 0);
        }
    }
}