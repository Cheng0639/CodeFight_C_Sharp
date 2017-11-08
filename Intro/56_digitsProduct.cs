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
        public static int digitsProduct(int product)
        {
            var answerDigits = string.Empty;

            if (product == 0) { return 10; }
            if (product == 1) { return 1; }

            for (var divisor = 9; divisor > 1; divisor--)
            {
                while (product % divisor == 0)
                {
                    product /= divisor;
                    answerDigits += divisor;
                }
            }

            if (product > 1) { return -1; }

            return Convert.ToInt32(new string(answerDigits.Reverse().ToArray()));
        }
        public static void No56_digitsProduct_Run()
        {
            Console.WriteLine(digitsProduct(12) == 26);
            Console.WriteLine(digitsProduct(19) == -1);
            Console.WriteLine(digitsProduct(450) == 2559);
            Console.WriteLine(digitsProduct(0) == 10);
            Console.WriteLine(digitsProduct(13) == -1);
            Console.WriteLine(digitsProduct(1) == 1);
            Console.WriteLine(digitsProduct(243) == 399);
            Console.WriteLine(digitsProduct(576) == 889);
            Console.WriteLine(digitsProduct(360) == 589);
        }
    }
}