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
        public static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select(x => x == elemToReplace ? substitutionElem : x).ToArray();
        }

        public static void No25_arrayReplace_Run()
        {
            Console.WriteLine(arrayReplace(new int[] { 1, 2, 1 }, 1, 3).SequenceEqual(new int[] { 3, 2, 3 }));
            Console.WriteLine(arrayReplace(new int[] { 1, 2, 3, 4, 5 }, 3, 0).SequenceEqual(new int[] { 1, 2, 0, 4, 5 }));
            Console.WriteLine(arrayReplace(new int[] { 1, 1, 1 }, 1, 10).SequenceEqual(new int[] { 10, 10, 10 }));
        }
    }
}