using System.Text.RegularExpressions;

namespace SimpleGoogleTranslate
{
    public static class GoogleTranslateStringParser
    {
        public static string Fix(string input)
        {
            input = input.StringFix(@" \.", @".");
            input = input.StringFix(@" ,", @",");
            return input;
        }

        private static string StringFix(this string input, string patern, string replaceWith)
        {
            return Regex.IsMatch(input, patern) 
                ? Regex.Replace(input, patern, replaceWith) 
                : input;
        }
    }
}