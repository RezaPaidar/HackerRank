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

class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
if (year == 1918)
        {
            // Special case: Transition year from Julian to Gregorian calendar
            return "26.09.1918";
        }
        else if ((year < 1918 && year % 4 == 0) || // Julian leap year
                 (year > 1918 && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)))) // Gregorian leap year
        {
            // Day of the Programmer falls on the 256th day (January to August have 31+29+31+30+31+30+31+31=243 days)
            return "12.09." + year.ToString();
        }
        else
        {
            // Day of the Programmer falls on the 256th day (January to August have 31+28+31+30+31+30+31+31=242 days)
            return "13.09." + year.ToString();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
