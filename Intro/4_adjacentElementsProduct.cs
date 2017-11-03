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
        public static int adjacentElementsProduct(int[] inputArray)
        {
            return Enumerable.Range(0, inputArray.Length - 1).Max(x => inputArray[x] * inputArray[x + 1]);
        }
        public static void No4_adjacentElementsProduct_Run()
        {
            Console.WriteLine(adjacentElementsProduct(new int[] { 3, 6, -2, -5, 7, 3 }) == 21);
            Console.WriteLine(adjacentElementsProduct(new int[] { -1, -2 }) == 2);
            Console.WriteLine(adjacentElementsProduct(new int[] { 5, 1, 2, 3, 1, 4 }) == 6);
            Console.WriteLine(adjacentElementsProduct(new int[] { 1, 2, 3, 0 }) == 6);
        }
    }
}