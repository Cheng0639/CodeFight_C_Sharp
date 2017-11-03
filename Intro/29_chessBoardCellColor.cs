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
        public static bool chessBoardCellColor(string cell1, string cell2)
        {
            Func<char, char, bool> func = new Func<char, char, bool>(
                (x, y) =>
                {
                    return ((Convert.ToInt32(x) + Convert.ToInt32(y)) % 2) == 0;
                }
            );

            return func(cell1[0], cell1[1]) == func(cell2[0], cell2[1]);

        }

        public static void No29_chessBoardCellColor_Run()
        {
            Console.WriteLine(chessBoardCellColor("A1", "C3") == true);
            Console.WriteLine(chessBoardCellColor("D2", "D2") == true);
            Console.WriteLine(chessBoardCellColor("A2", "A5") == false);
            Console.WriteLine(chessBoardCellColor("C8", "H8") == false);
        }
    }
}