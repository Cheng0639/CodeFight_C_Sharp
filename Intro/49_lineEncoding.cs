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
        public static string lineEncoding(string s)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            char current;
            int count;
            while (index < s.Length)
            {
                current = s[index];
                count = s.Skip(index).TakeWhile(x => x == current).Count();
                sb.Append($"{(count > 1 ? count.ToString() : string.Empty)}{current}");

                index += count;
            }

            return sb.ToString();

        }

        public static void No49_lineEncoding_Run()
        {
            Console.WriteLine(lineEncoding("aabbbc") == "2a3bc");
            Console.WriteLine(lineEncoding("abbcabb") == "a2bca2b");
            Console.WriteLine(lineEncoding("abcd") == "abcd");
        }
    }
}