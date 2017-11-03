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
        static int[] alternatingSums(int[] a)
        {
            var odd = a.Where((c, i) => i % 2 == 1);
            var even = a.Where((c, i) => i % 2 == 0);
            return new int[] { even.Sum(), odd.Sum() };
        }

        public static void No14_alternatingSums_Run()
        {
            Console.WriteLine(alternatingSums(new int[] { 50, 60, 60, 45, 70 }).SequenceEqual(new int[] { 180, 105 }));
            Console.WriteLine(alternatingSums(new int[] { 100, 50 }).SequenceEqual(new int[] { 100, 50 }));
            Console.WriteLine(alternatingSums(new int[] { 80 }).SequenceEqual(new int[] { 80, 0 }));
        }
    }
}