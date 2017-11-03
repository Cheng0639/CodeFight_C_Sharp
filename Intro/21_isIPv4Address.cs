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
        public static bool isIPv4Address(string inputString)
        {
            return inputString.Split('.').Length == 4
                            && !inputString.Split('.')
                                            .Any(x =>
                                            {
                                                int rlt = -1;
                                                if (x.Equals(string.Empty) || !int.TryParse(x, out rlt) || rlt < 0 || rlt > 255)
                                                {
                                                    return true;
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                        );
        }

        public static bool isIPv4Address_1(string inputString)
        {
            System.Net.IPAddress tmp;
            return System.Net.IPAddress.TryParse(inputString, out tmp);
        }

        public static void No21_isIPv4Address_Run()
        {
            Console.WriteLine(isIPv4Address("172.16.254.1") == true);
            Console.WriteLine(isIPv4Address("172.316.254.1") == false);
            Console.WriteLine(isIPv4Address("0.1.0.0") == true);
            Console.WriteLine(isIPv4Address("2001:0db8:85a3:0000:0000:8a2e:0370:7334") == false);
            Console.WriteLine(isIPv4Address("0.1.0.0.") == false);

            Console.WriteLine(isIPv4Address_1("172.16.254.1") == true);
            Console.WriteLine(isIPv4Address_1("172.316.254.1") == false);
            Console.WriteLine(isIPv4Address_1("0.1.0.0") == true);
            //IPv6
            Console.WriteLine(isIPv4Address_1("2001:0db8:85a3:0000:0000:8a2e:0370:7334") == false);
            Console.WriteLine(isIPv4Address_1("0.1.0.0.") == false);

        }
    }
}