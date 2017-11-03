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
        public static bool areSimilar(int[] a, int[] b)
        {
            if (a.SequenceEqual(b)) { return true; }
            var dicA = a.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var dicB = b.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return dicA.Except(dicB).Count() == 0
                    && Enumerable.Range(0, a.Length).Select(x => a[x] != b[x]).Count(x => x) <= 2;
        }

        public static void No16_areSimilar_Run()
        {
            Console.WriteLine(areSimilar(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }) == true);
            Console.WriteLine(areSimilar(new int[] { 1, 2, 3 }, new int[] { 2, 1, 3 }) == true);
            Console.WriteLine(areSimilar(new int[] { 1, 2, 2 }, new int[] { 2, 1, 1 }) == false);
            Console.WriteLine(areSimilar(new int[] { 1, 2, 3 }, new int[] { 1, 10, 2 }) == false);
        }
    }
}