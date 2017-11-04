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
        public static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            return upSpeed > desiredHeight ? 1 : (int)Math.Floor(desiredHeight / (upSpeed - downSpeed) * 1.0);
        }


        public static void No38_growingPlant_Run()
        {
            Console.WriteLine(growingPlant(100, 10, 910) == 10);
            Console.WriteLine(growingPlant(10, 9, 4) == 1);
        }
    }
}