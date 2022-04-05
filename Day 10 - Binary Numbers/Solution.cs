using System.CodeDom.Compiler;
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



class SolutionDay10
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string ans = Convert.ToString(n, 2);
        int count = 0;
        int max = 0;
        char pre = ' ';
        foreach (char c in ans)
        {
            if (c == pre)
            {
                count++;
            }
            else
            {
                pre = c;
                max = Math.Max(max, count);
                count = 1;
            }
        }
        Console.WriteLine(Math.Max(max, count));
    }
}
