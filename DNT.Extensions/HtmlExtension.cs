using System.Text.RegularExpressions;

namespace DNT.Extensions
{
    public static class HtmlExtension
    {
        public static string StripTagsRegex(this string source)
        {
            return Regex.Replace(source, "<.?*>", string.Empty);
        }
        public static string StripTagsRegex(this string source, string replacement)
        {
            return Regex.Replace(source, "<.?*>", string.Empty);
        }
        public static string RemoveHtmlTags(this string source)
        {
            return string.IsNullOrEmpty(source) ? source : Regex.Replace(source, @"<(.|\n)*?>", string.Empty);
        }

    }
}
