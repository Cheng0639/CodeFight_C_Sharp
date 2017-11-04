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
        public static bool bishopAndPawn(string bishop, string pawn)
        {
            return Math.Abs(((bishop[1] - '0') - (pawn[1] - '0') * 1.0) / ((bishop[0] - 'a' + 1) - (pawn[0] - 'a' + 1) * 1.0)) == 1;
        }

        public static void No42_bishopAndPawn_Run()
        {
            Console.WriteLine(bishopAndPawn("a1", "c3") == true);
            Console.WriteLine(bishopAndPawn("h1", "h3") == false);
            Console.WriteLine(bishopAndPawn("e7", "a3") == true);
            Console.WriteLine(bishopAndPawn("e3", "a7") == false);
        }
    }
}