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
        public static bool isDigit(char symbol)
        {
            return Char.IsDigit(symbol);
        }

        public static void No48_isDigit_Run()
        {
            Console.WriteLine(isDigit('0') == true);
            Console.WriteLine(isDigit('-') == false);
            Console.WriteLine(isDigit('O') == false);
            Console.WriteLine(isDigit('1') == true);
            Console.WriteLine(isDigit('2') == true);
            Console.WriteLine(isDigit('!') == false);
            Console.WriteLine(isDigit('@') == false);
            Console.WriteLine(isDigit('+') == false);
        }
    }
}