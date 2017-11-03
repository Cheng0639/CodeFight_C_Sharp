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
        public static string reverseParentheses(string s)
        {
            int left = s.LastIndexOf('(');
            if (left == -1)
            {
                return s;
            }
            else
            {
                int right = s.IndexOf(')', left);

                return reverseParentheses(
                      s.Substring(0, left)
                    + new string(s.Substring(left + 1, right - left - 1).Reverse().ToArray())
                    + s.Substring(right + 1)
                );
            }
        }
        public static void No13_reverseParentheses_Run()
        {
            Console.WriteLine(reverseParentheses("a(bc)de") == "acbde");
            Console.WriteLine(reverseParentheses("a(bcdefghijkl(mno)p)q") == "apmnolkjihgfedcbq");
            Console.WriteLine(reverseParentheses("co(de(fight)s)") == "cosfighted");
            Console.WriteLine(reverseParentheses("Code(Cha(lle)nge)") == "CodeegnlleahC");
            Console.WriteLine(reverseParentheses("Where are the parentheses?") == "Where are the parentheses?");
            Console.WriteLine(reverseParentheses("abc(cba)ab(bac)c") == "abcabcabcabc");
            Console.WriteLine(reverseParentheses("The ((quick (brown) (fox) jumps over the lazy) dog)") == "The god quick nworb xof jumps over the lazy");
        }
    }
}