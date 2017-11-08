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
        public static int electionsWinners(int[] votes, int k)
        {
            var max = votes.Max();
            return (k == 0) ? Convert.ToInt32(votes.Count(x => x == max) == 1) : votes.Count(x => x + k > max);
        }

        public static void No46_electionsWinners_Run()
        {
            Console.WriteLine(electionsWinners(new int[] { 2, 3, 5, 2 }, 3) == 2);
            Console.WriteLine(electionsWinners(new int[] { 1, 3, 3, 1, 1 }, 0) == 0);
            Console.WriteLine(electionsWinners(new int[] { 5, 1, 3, 4, 1 }, 0) == 1);
            Console.WriteLine(electionsWinners(new int[] { 1, 1, 1, 1 }, 1) == 4);
            Console.WriteLine(electionsWinners(new int[] { 1, 1, 1, 1 }, 0) == 0);
            Console.WriteLine(electionsWinners(new int[] { 3, 1, 1, 3, 1 }, 2) == 2);
        }
    }
}