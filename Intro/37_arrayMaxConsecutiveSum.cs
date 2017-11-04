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
        public static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            if (k == 1)
            {
                return inputArray.Max();
            }
            else if (k > inputArray.Length)
            {
                return inputArray.Sum();
            }
            else
            {
                int prev = inputArray[0];
                int sum = inputArray.Take(k).Sum();
                int max = inputArray.Take(k).Sum();
                for (int i = k; i < inputArray.Length; i++)
                {
                    sum = sum + inputArray[i] - prev;
                    prev = inputArray[i - k + 1];
                    if (max < sum) { max = sum; }
                }
                return max;
            }
        }

        public static int arrayMaxConsecutiveSum1(int[] inputArray, int k)
        {
            return Enumerable.Range(0, inputArray.Length - k + 1).Select((x, i) => inputArray.Skip(i).Take(k).Sum()).Max();
        }

        public static void No37_arrayMaxConsecutiveSum_Run()
        {
            Console.WriteLine(arrayMaxConsecutiveSum(new int[] { 2, 3, 5, 1, 6 }, 2) == 8);
            Console.WriteLine(arrayMaxConsecutiveSum(new int[] { 2, 4, 10, 1 }, 2) == 14);
            Console.WriteLine(arrayMaxConsecutiveSum(new int[] { 1, 3, 2, 4 }, 3) == 9);
        }
    }
}