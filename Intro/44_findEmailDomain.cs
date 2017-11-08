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
        public static string findEmailDomain(string address)
        {
            return address.Substring(address.LastIndexOf('@') + 1);
        }

        public static void No44_findEmailDomain_Run()
        {
            Console.WriteLine(findEmailDomain("prettyandsimple@example.com") == "example.com");
            Console.WriteLine(findEmailDomain("<>[]:,;@\"!#$%&*+-/=?^_{}| ~.a\"@example.org") == "example.org");
            Console.WriteLine(findEmailDomain("someaddress@yandex.ru") == "yandex.ru");
            Console.WriteLine(findEmailDomain("\" \"@xample.org") == "xample.org");
        }
    }
}