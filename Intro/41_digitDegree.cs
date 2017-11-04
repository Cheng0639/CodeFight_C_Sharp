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
        public static int digitDegree(int n)
        {
            int cnt = 0;
            string tmp = string.Empty;

            while (n >= 10)
            {
                tmp = n.ToString();
                n = tmp.Sum(x => x - '0');
                cnt++;
            }

            return cnt;
        }

        public static void No41_digitDegree_Run()
        {
            Console.WriteLine(digitDegree(5) == 0);
            Console.WriteLine(digitDegree(100) == 1);
            Console.WriteLine(digitDegree(91) == 2);
            Console.WriteLine(digitDegree(99) == 2);
        }
    }
}