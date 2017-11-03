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
        public static int add(int param1, int param2)
        {
            return param1 + param2;
        }
        public static void No1_add()
        {
            Console.WriteLine(add(2, 3) == 5);
            Console.WriteLine(add(0, 1000) == 1000);
        }
    }
}