using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT.Extensions
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

    }
}
