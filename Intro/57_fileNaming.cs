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
        public static string[] fileNaming(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Take(i).Contains(names[i]))
                {
                    int cnt = 1;
                    while (names.Take(i).Contains($"{names[i]}({cnt})")) { cnt++; }
                    names[i] = $"{names[i]}({cnt})";
                }
            }
            return names;
        }
        public static void No57_fileNaming_Run()
        {
            Console.WriteLine(fileNaming(new string[] { "doc", "doc", "image", "doc(1)", "doc" }).SequenceEqual(new string[] { "doc", "doc(1)", "image", "doc(1)(1)", "doc(2)" }));
            Console.WriteLine(fileNaming(new string[] { "a(1)", "a(6)", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a" }).SequenceEqual(new string[] { "a(1)", "a(6)", "a", "a(2)", "a(3)", "a(4)", "a(5)", "a(7)", "a(8)", "a(9)", "a(10)", "a(11)" }));
            Console.WriteLine(fileNaming(new string[] { "dd", "dd(1)", "dd(2)", "dd", "dd(1)", "dd(1)(2)", "dd(1)(1)", "dd", "dd(1)" }).SequenceEqual(new string[] { "dd", "dd(1)", "dd(2)", "dd(3)", "dd(1)(1)", "dd(1)(2)", "dd(1)(1)(1)", "dd(4)", "dd(1)(3)" }));
        }
    }
}