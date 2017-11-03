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
        public static int makeArrayConsecutive2(int[] statues)
        {
            return statues.Max() - statues.Min() - statues.Length + 1;
        }

        public static void No6_makeArrayConsecutive2_Run()
        {
            Console.WriteLine(makeArrayConsecutive2(new int[] { 6, 2, 3, 8 }) == 3);
            Console.WriteLine(makeArrayConsecutive2(new int[] { 0, 3 }) == 2);
            Console.WriteLine(makeArrayConsecutive2(new int[] { 5, 4, 6 }) == 0);
            Console.WriteLine(makeArrayConsecutive2(new int[] { 6, 3 }) == 2);
            Console.WriteLine(makeArrayConsecutive2(new int[] { 1 }) == 0);
        }
    }
}