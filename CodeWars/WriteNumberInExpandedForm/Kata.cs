using System;
using System.Linq;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        string result = "";
        string numString = num.ToString();

        for (var i = 0; i < numString.Length; i++)
        {
            if (numString[i] != '0')
            {
                result += numString[i]; 
                result += new string('0', numString.Length - i - 1);
                result += " + ";
            }
        }

        return result.Substring(0, result.Length - 3);
    }
}