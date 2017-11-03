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
        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return (yourLeft == friendsLeft || yourLeft == friendsRight)
                && (yourRight == friendsRight || yourRight == friendsLeft);
        }

        public static void No19_areEquallyStrong_Run()
        {
            Console.WriteLine(areEquallyStrong(10, 15, 15, 10) == true);
            Console.WriteLine(areEquallyStrong(15, 10, 15, 10) == true);
            Console.WriteLine(areEquallyStrong(15, 10, 15, 9) == false);
            Console.WriteLine(areEquallyStrong(20, 15, 5, 20) == false);
        }
    }
}