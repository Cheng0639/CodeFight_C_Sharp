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
        public static int deleteDigit(int n)
        {
            string s = n.ToString();
            return Enumerable.Range(0, s.Length).Select(x => int.Parse(s.Remove(x, 1))).Max();
        }

        public static void No51_deleteDigit_Run()
        {

            Console.WriteLine(deleteDigit(152) == 52);
            Console.WriteLine(deleteDigit(1001) == 101);
            Console.WriteLine(deleteDigit(10) == 1);
            Console.WriteLine(deleteDigit(222219) == 22229);
        }
    }
}