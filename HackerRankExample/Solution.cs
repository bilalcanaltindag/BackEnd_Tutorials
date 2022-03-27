﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRankExample
{
    class Solution
    {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = new List<int>();

                for (int i = 0; i < arrCount; i++)
                {
                    int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                    arr.Add(arrItem);
                }

                int result = Result.maxPosPrefixes(arr);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
    }
}

