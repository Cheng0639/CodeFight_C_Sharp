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
        public static char firstDigit(string inputString)
        {
            return inputString.First(x => Char.IsDigit(x));
        }


        public static void No35_firstDigit_Run()
        {
            Console.WriteLine(firstDigit("var_1__Int") == '1');
            Console.WriteLine(firstDigit("q2q-q") == '2');
            Console.WriteLine(firstDigit("0ss") == '0');
        }
    }
}