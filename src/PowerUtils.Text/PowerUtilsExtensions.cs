using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PowerUtils.Text
{
    public static class PowerUtilsExtensions
    {
        #region PRIVATE VARIABLES
        private static readonly List<char> CHARS_TO_SPLIT1 = new List<char>() { ' ', '-', '.', '(' };
        private static readonly List<char> CHARS_TO_SPLIT2 = new List<char>() { '\'' };
        #endregion

        /// <summary>
        /// Clean extra spaces. Replace tabs to one space and double spaces to one space
        /// </summary>
        /// <param name="text">Text input</param>
        /// <returns>Clear string</returns>
        public static string CleanExtraSpaces(this string input)
        {
            if(input == null)
            {
                return null;
            }

            input = Regex.Replace(input, "\t", " "); // Remove tabs
            input = Regex.Replace(input, " +", " "); // Remove more than two spaces
            input = Regex.Replace(input, @"(\r\n?|\n) ", Environment.NewLine); // Clean spaces after line breaks
            input = Regex.Replace(input, @" (\r\n?|\n)", Environment.NewLine); // Clean spaces before line breaks

            input = input.Trim();

            return input;
        }

        /// <summary>
        /// Clean extra line breaks. Replace double line breaks to one line break
        /// </summary>
        /// <param name="input">Text input</param>
        /// <returns>Clear text</returns>
        public static string CleanExtraLineBreak(this string input)
        {
            if(input == null)
            {
                return null;
            }

            input = Regex.Replace(input, @"(\r\n?|\n)+", Environment.NewLine); // Clean double line breaks
            input = Regex.Replace(input, @"(\r\n?|\n) +", Environment.NewLine); // Clean spaces after line breaks
            input = Regex.Replace(input, @" +(\r\n?|\n)", Environment.NewLine); // Clean spaces before line breaks

            return input;
        }

        /// <summary>
        /// Clean extra spaces, override tabs to one space, double spaces to one space and double line breaks to one line break
        /// </summary>
        /// <param name="input">Text input</param>
        /// <returns>Clear text</returns>
        public static string CleanExtraLineBreakAndLineBreak(this string input)
        {
            return input
                .CleanExtraSpaces()
                .CleanExtraLineBreak();
        }

        /// <summary>
        /// Convert a string with empty or white spaces to null
        /// </summary>
        /// <param name="input">Text input</param>
        /// <returns>Clear text</returns>
        public static string EmptyOrWhiteSpace(this string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// Compress text if greater the max length
        /// </summary>
        /// <param name="input">Text to be checked</param>
        /// <param name="maxLength">Maximum character length</param>
        /// <returns>Compressed text</returns>
        public static string CompressText(this string input, int maxLength)
        {
            if(input == null)
            {
                return null;
            }
            else
            {
                input = input.TrimEnd();

                if(input.Length > maxLength)
                {
                    return input.Substring(0, maxLength - 1) + "…";
                }
                else
                {
                    return input;
                }
            }
        }

        /// <summary>
        /// Truncate text if greater the max length
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="maxLength">Maximum character length</param>
        /// <returns>Compressed text</returns>
        public static string Truncate(this string input, int maxLength)
        {
            if(input == null)
            {
                return null;
            }

            maxLength = Math.Min(input.Length, maxLength);
            return input.Substring(0, maxLength);
        }
    }
}