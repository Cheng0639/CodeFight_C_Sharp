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
        public static bool checkPalindrome(string inputString)
        {
            return inputString.Equals(inputString.Reverse());
        }

        public static void No3_checkPalindrome_Run()
        {
            Console.WriteLine(checkPalindrome("aabaa") == true);
            Console.WriteLine(checkPalindrome("abac") == false);
            Console.WriteLine(checkPalindrome("a") == true);
            Console.WriteLine(checkPalindrome("az") == false);
            Console.WriteLine(checkPalindrome("abacaba") == true);
            Console.WriteLine(checkPalindrome("aaabaaaa") == false);
            Console.WriteLine(checkPalindrome("zzzazzazz") == false);
            Console.WriteLine(checkPalindrome("hlbeeykoqqqqokyeeblh") == true);
        }
    }
}