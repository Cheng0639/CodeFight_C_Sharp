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
        public static int differentSymbolsNaive(string s)
        {
            return s.Distinct().Count();
        }


        public static void No36_differentSymbolsNaive_Run()
        {
            Console.WriteLine(differentSymbolsNaive("cabca") == 3);
            Console.WriteLine(differentSymbolsNaive("aba") == 2);
        }
    }
}