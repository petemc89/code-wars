using System;

namespace WhatCenturyIsIt
{
    public class Kata
    {
        public static string WhatCentury(string year)
        {
            int milleniumCenturyDigits = int.Parse(year.Substring(0, 2));

            int century = year.Substring(1, 3) == "000" ? milleniumCenturyDigits : milleniumCenturyDigits + 1;

            return DisplayWithSuffix(century);
        }

        private static string DisplayWithSuffix(int num)
        {
            //Inspired by https://stackoverflow.com/a/19553611/11492151

            string number = num.ToString();

            if (number.EndsWith("11")) return number + "th";
            if (number.EndsWith("12")) return number + "th";
            if (number.EndsWith("13")) return number + "th";
            if (number.EndsWith("1")) return number + "st";
            if (number.EndsWith("2")) return number + "nd";
            if (number.EndsWith("3")) return number + "rd";

            return number + "th";
        }
    }
}
