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
        public static string[] addBorder(string[] picture)
        {
            var rlt = new string[] { new string('*', picture[0].Length + 2) };
            return rlt.Concat(picture.Select(s => "*" + s + "*"))
                .Concat(rlt)
                .ToArray();
        }
        public static void No15_addBorder_Run()
        {
            Console.WriteLine(addBorder(new string[] { "abc", "ded" }).SequenceEqual(new string[] { "*****", "*abc*", "*ded*", "*****" }));
            Console.WriteLine(addBorder(new string[] { "a" }).SequenceEqual(new string[] { "***", "*a*", "***" }));
        }
    }
}