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
        public static string messageFromBinaryCode(string code)
        {
            var qe = new Queue(code.ToArray());
            return new string(Enumerable.Range(0, code.Length / 8).Select(x => (char)(Convert.ToInt32(new string(code.Skip(8 * x).Take(8).ToArray()), 2))).ToArray());
        }
        public static void No58_messageFromBinaryCode_Run()
        {
            Console.WriteLine(messageFromBinaryCode("010010000110010101101100011011000110111100100001") == "Hello!");
            Console.WriteLine(messageFromBinaryCode("01001101011000010111100100100000011101000110100001100101001000000100011001101111011100100110001101100101001000000110001001100101001000000111011101101001011101000110100000100000011110010110111101110101") == "May the Force be with you");
            Console.WriteLine(messageFromBinaryCode("010110010110111101110101001000000110100001100001011001000010000001101101011001010010000001100001011101000010000001100000011010000110010101101100011011000110111100101110") == "You had me at `hello.");
        }
    }
}