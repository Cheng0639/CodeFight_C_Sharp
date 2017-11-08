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
        public static bool isMAC48Address(string inputString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(inputString, "^[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}$");
        }

        public static void No47_isMAC48Address_Run()
        {
            Console.WriteLine(isMAC48Address("00-1B-63-84-45-E6") == true);
            Console.WriteLine(isMAC48Address("Z1-1B-63-84-45-E6") == false);
            Console.WriteLine(isMAC48Address("not a MAC-48 address") == false);
            Console.WriteLine(isMAC48Address("FF-FF-FF-FF-FF-FF") == true);
            Console.WriteLine(isMAC48Address("00-00-00-00-00-00") == true);
            Console.WriteLine(isMAC48Address("G0-00-00-00-00-00") == false);
            Console.WriteLine(isMAC48Address("02-03-04-05-06-07-") == false);
            Console.WriteLine(isMAC48Address("12-34-56-78-9A-BC") == true);
        }
    }
}