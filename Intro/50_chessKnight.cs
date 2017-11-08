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
        public static int chessKnight(string cell)
        {
            int boundry = 7;
            var tmp = Enumerable.Range(-2, 5).Where(x => x != 0);
            var possible = tmp.SelectMany(x => tmp.Select(y => new { x = x, y = y })).Where(_ => Math.Abs(_.x) != Math.Abs(_.y)).ToArray();
            var pos = new { x = cell[0] - 'a', y = cell[1] - '0' - 1 };

            return possible.Count(
                _ =>
                {
                    int x = pos.x + _.x;
                    int y = pos.y + _.y;
                    return (x >= 0 && x <= boundry) && (y >= 0 && y <= boundry);
                }
            );
        }

        public static void No50_chessKnight_Run()
        {
            Console.WriteLine(chessKnight("a1") == 2);
            Console.WriteLine(chessKnight("c2") == 6);
            Console.WriteLine(chessKnight("d4") == 8);
            Console.WriteLine(chessKnight("g6") == 6);
        }
    }
}