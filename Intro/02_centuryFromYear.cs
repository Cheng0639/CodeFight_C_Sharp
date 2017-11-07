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
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public static void No2_centuryFromYear_Run()
        {
            Console.WriteLine(centuryFromYear(1905) == 20);
            Console.WriteLine(centuryFromYear(1700) == 17);
            Console.WriteLine(centuryFromYear(1988) == 20);
            Console.WriteLine(centuryFromYear(2001) == 21);
        }
    }
}