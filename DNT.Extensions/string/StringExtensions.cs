using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DNT.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// Enable quick and more natural string.Format calls
        /// </summary>
        /// <param name="s"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string F(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static string Shorten(this string str, int toLength, string cutOffReplacement = " ...")
        {
            if (string.IsNullOrEmpty(str) || str.Length <= toLength)
                return str;
            else
                return str.Remove(toLength) + cutOffReplacement;
        }

        public static string UpperCaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        public static bool IsNumeric(this string value)
        {
            float output;
            return float.TryParse(value,out output);
        }

        public static int WordCount(this string value)
        {
            string[] val = value.Split(new char[] { ' ','.','?'},StringSplitOptions.RemoveEmptyEntries);
            int count = val.Length;
            return count;
        }
        public static string TrimAndReduceSpaces(this string value)
        {
            return ConvertSpacesToSingleSpace(value).Trim();
        }
        public static string ConvertSpacesToSingleSpace(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }
    }
}
