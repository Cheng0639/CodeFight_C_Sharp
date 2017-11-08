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
        public static bool validTime(string time)
        {
            DateTime d;
            return DateTime.TryParseExact(time, "HH:mm", null, DateTimeStyles.None, out d);
        }

        public static void No53_validTime_Run()
        {
            Console.WriteLine(validTime("13:58") == true);
            Console.WriteLine(validTime("25:51") == false);
            Console.WriteLine(validTime("02:76") == false);
            Console.WriteLine(validTime("24:00") == false);
        }
    }
}