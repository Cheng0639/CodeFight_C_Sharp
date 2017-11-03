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
        public static string alphabeticShift(string inputString)
        {
            return new string(
                inputString.Select(x =>
                   Convert.ToChar(x.Equals('z') ? 'a' : ((int)x) + 1))
                .ToArray()
            );
        }

        public static void No28_alphabeticShift_Run()
        {
            Console.WriteLine(alphabeticShift("crazy") == "dsbaz");
            Console.WriteLine(alphabeticShift("z") == "a");
        }
    }
}