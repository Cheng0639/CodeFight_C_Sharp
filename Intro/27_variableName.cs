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
        public static bool variableName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z_][a-zA-Z_0-9]*$");
        }
        public static void No27_variableName_Run()
        {
            Console.WriteLine(variableName("var_1__Int") == true);
            Console.WriteLine(variableName("qq-q") == false);
            Console.WriteLine(variableName(" variable") == false);
            Console.WriteLine(variableName("va[riable0") == false);
            Console.WriteLine(variableName("variable0") == true);
        }
    }
}