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
        public static int circleOfNumbers(int n, int firstNumber)
        {
            return firstNumber >= n / 2 ? Math.Abs(n / 2 - firstNumber) : n / 2 + firstNumber;
        }

        public static void No30_circleOfNumbers_Run()
        {
            Console.WriteLine(circleOfNumbers(10, 2) == 7);
            Console.WriteLine(circleOfNumbers(10, 7) == 2);
            Console.WriteLine(circleOfNumbers(4, 1) == 3);
            Console.WriteLine(circleOfNumbers(6, 3) == 0);
        }
    }
}