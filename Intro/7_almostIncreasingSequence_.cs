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
        public static bool almostIncreasingSequence(int[] sequence)
        {
            int r = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    r++;
                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                    r++;
            }
            return r <= 2;
        }

        public static void No7_almostIncreasingSequence_Run()
        {
            Console.WriteLine(almostIncreasingSequence(new int[] { 1, 3, 2, 1 }) == false);
            Console.WriteLine(almostIncreasingSequence(new int[] { 1, 3, }) == true);
            Console.WriteLine(almostIncreasingSequence(new int[] { 1, 2, 1, 2 }) == false);
            Console.WriteLine(almostIncreasingSequence(new int[] { 1, 4, 10, 4, 2 }) == false);
        }
    }
}