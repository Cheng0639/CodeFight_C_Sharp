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
        public static bool evenDigitsOnly(int n)
        {
            return n.ToString().All(x => (int)x % 2 == 0);
        }

        public static void No26_evenDigitsOnly_Run()
        {
            Console.WriteLine(evenDigitsOnly(248622) == true);
            Console.WriteLine(evenDigitsOnly(642386) == false);
            Console.WriteLine(evenDigitsOnly(1) == false);
            Console.WriteLine(evenDigitsOnly(8) == true);
            Console.WriteLine(evenDigitsOnly(2462487) == false);
            Console.WriteLine(evenDigitsOnly(468402800) == true);
            Console.WriteLine(evenDigitsOnly(5468428) == false);
        }
    }
}