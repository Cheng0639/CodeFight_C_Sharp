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
        public static int[] sortByHeight(int[] a)
        {
            int[] num = a.Where(x => x != -1).OrderBy(x => x).ToArray();
            int cnt = 0;

            return a.Select(x => x >= 0 ? num[cnt++] : -1).ToArray();
        }
        public static void No12_sortByHeight_Run()
        {
            Console.WriteLine(sortByHeight(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 }).SequenceEqual(new int[] { -1, 150, 160, 170, -1, -1, 180, 190 }));
            Console.WriteLine(sortByHeight(new int[] { -1, -1, -1, -1, -1 }).SequenceEqual(new int[] { -1, -1, -1, -1, -1 }));
            Console.WriteLine(sortByHeight(new int[] { 4, 2, 9, 11, 2, 16 }).SequenceEqual(new int[] { 2, 2, 4, 9, 11, 16 }));
        }
    }
}