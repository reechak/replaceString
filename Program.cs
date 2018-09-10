using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int number;
            bool isNumeric = int.TryParse(line, out number);
            var newLine = "";

            if (!isNumeric)
            {
                newLine = replaceString(line);
                Console.WriteLine(newLine);
            }

        }
    }

    public static string replaceString(string input)
    {
        return Regex.Replace(input, @"\s+", "%20");

    }



}