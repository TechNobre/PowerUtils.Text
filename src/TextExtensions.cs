using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PowerUtils.Text
{
    /// <summary>
    /// Extensions for manipulating strings
    /// </summary>
    public static class TextExtensions
    {
        private static char[] CHARS_TO_SPLIT1 = new char[] { ' ', '-', '.', '(' };
        private static char[] CHARS_TO_SPLIT2 = new char[] { '\'' };


        /// <summary>
        /// Clean extra spaces. Replace tabs to one space and double spaces to one space
        /// </summary>
        /// <param name="input">Input text</param>
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
        /// <param name="input">Input text</param>
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
        /// <param name="input">Input text</param>
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
        /// <param name="input">Input text</param>
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

        /// <summary>
        /// Uppercase the first character
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>New string</returns>
        public static string UppercaseFirst(this string input)
        {
            if(input == null)
            {
                return null;
            }

            if(input == string.Empty)
            {
                return string.Empty;
            }

            char[] charArray = input.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        /// <summary>
        /// Capitalize the people and company names
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>Capitalized name</returns>
        public static string CapitalizeName(this string input)
        {
            if(input == null)
            {
                return null;
            }

            if(input == string.Empty)
            {
                return string.Empty;
            }

            char[] splitedText = string
                .Join(
                    " ",
                    input.ToLower().Split() // To lower and replace special spaces
                )
                .ToCharArray();

            splitedText[0] = char.ToUpper(splitedText[0]); // To Upper first character
            int length = splitedText.Length;
            for(int count = 1; count < length; count++)
            {
                if(CHARS_TO_SPLIT1.Contains(splitedText[count - 1]))
                {
                    splitedText[count] = char.ToUpper(splitedText[count]);
                }
                else if(count == 1 && CHARS_TO_SPLIT2.Contains(splitedText[count - 1]))
                {
                    splitedText[count] = char.ToUpper(splitedText[count]);
                }
                else if(count > 1 && CHARS_TO_SPLIT2.Contains(splitedText[count - 1]) && (splitedText[count - 2] == ' ' || splitedText[count - 2] == '-'))
                {
                    splitedText[count] = char.ToUpper(splitedText[count]);
                }
            }

            return new string(splitedText);
        }

        /// <summary>
        /// Replace all special characters in a string for other character [Default: any character]
        /// </summary>
        /// <param name="input">Input string to clear</param>
        /// <param name="substitute">New character to override special characters</param>
        /// <returns>New string clean</returns>
        public static string CleanSpecialCharacters(this string input, string substitute = "")
        {
            if(input == null)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();
            foreach(char character in input)
            {
                if(
                    (character >= '0' && character <= '9')
                    ||
                    (character >= 'A' && character <= 'Z')
                    ||
                    (character >= 'a' && character <= 'z')
                    ||
                    character == '.'
                    ||
                    character == '_'
                )
                {
                    sb.Append(character);
                }
                else
                {
                    sb.Append(substitute);
                }
            }
            return sb.ToString();
        }
    }
}