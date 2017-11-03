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
        public static int shapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }
        public static void No5_shapeArea_Run()
        {
            Console.WriteLine(shapeArea(2) == 5);
            Console.WriteLine(shapeArea(3) == 13);
            Console.WriteLine(shapeArea(1) == 1);
            Console.WriteLine(shapeArea(5) == 41);
        }
    }
}