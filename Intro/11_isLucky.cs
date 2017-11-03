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
        public static bool isLucky(int n)
        {
            return n.ToString().Substring(0, (int)n.ToString().Length / 2).Select(x => int.Parse(x.ToString())).Sum().Equals(n.ToString().Substring((int)n.ToString().Length / 2, n.ToString().Length - (int)n.ToString().Length / 2).Select(x => int.Parse(x.ToString())).Sum());
        }

        public static void No11_isLucky_Run()
        {
            Console.WriteLine(isLucky(1230) == true);
            Console.WriteLine(isLucky(239017) == false);
            Console.WriteLine(isLucky(134008) == true);
        }
    }
}