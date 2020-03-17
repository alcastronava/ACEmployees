using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ACEmployees.Extensions
{
    public static class StringExtensions
    {
        //Remove diacritics chars from a string, like accented chars
        public static string RemoveDiacritics(this String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Remove diacritics chars from a string, like accented chars
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemDiac(this string text)
        {
            if (text == null)
            {
                return string.Empty;
            }
            return string.Concat(
                text.Normalize(NormalizationForm.FormD)
                .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) !=
                                              UnicodeCategory.NonSpacingMark)
              ).Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// String extension that override 'Contains' method with white spaces removal, no case sensitive and diacritics search
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContainsDiac(this string text, string value)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(value))
            {
                return false;
            }
            text = text.RemoveDiacritics().ToUpperInvariant();
            value = value.RemoveDiacritics().Trim().ToUpperInvariant();
            return text.Contains(value /*, StringComparison.InvariantCultureIgnoreCase*/);
        }

        private static bool isMatch(this string text, string searchText)
        {
            return Regex.IsMatch(searchText, "\\b" + text + "\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        /// <summary>
        /// String extension that override 'Contains' method with whole words, white spaces removal, no case sensitive and diacritics search
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContainsDiacWholeWord(this string text, string value)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(value))
            {
                return false;
            }
            text = text.RemDiac();
            value = value.RemDiac().Trim();
            return text.isMatch(value); //Contains(value, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// String extension that override 'Equals' method with white spaces removal, no case sensitive and diacritics comparation
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool EqualsDiac(this string text, string value)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(value))
            {
                return false;
            }
            text = text.RemDiac().Trim();
            value = value.RemDiac().Trim();
            return text.Equals(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static string Truncate(this string text, int maxChars)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            if (text.Length <= maxChars)
            {
                return text;
            }

            int end = text.LastIndexOf(' ', maxChars);

            // Just one long word. Chop it off.
            if (end == -1)
            {
                return text.Substring(0, maxChars) + "...";
            }
            else
            {
                return text.Substring(0, end) + "...";
            }
        }
    }
}