using System;
using System.Globalization;
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
        private static readonly char[] _charsToSplit1 = new char[] { ' ', '-', '.', '(' };
        private static readonly char[] _charsToSplit2 = new char[] { '\'' };


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
            => input
                .CleanExtraSpaces()
                .CleanExtraLineBreak();

        /// <summary>
        /// Convert a string with empty or white spaces to null
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>Clear text</returns>
        public static string EmptyOrWhiteSpaceToNull(this string input)
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
                    return $"{input.Substring(0, maxLength - 1)}…";
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
        /// Capitalize the people and company names
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>Capitalized name</returns>
        public static string CapitalizeName(this string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            var splitedText = string
                .Join(
                    " ",
                    input.ToLower().Split() // To lower and replace special spaces
                )
                .ToCharArray();

            splitedText[0] = char.ToUpper(splitedText[0]); // To Upper first character
            var length = splitedText.Length;
            for(var count = 1; count < length; count++)
            {
                if(_charsToSplit1.Contains(splitedText[count - 1]))
                {
                    splitedText[count] = char.ToUpper(splitedText[count]);
                }
                else if(count == 1 && _charsToSplit2.Contains(splitedText[count - 1]))
                {
                    splitedText[count] = char.ToUpper(splitedText[count]);
                }
                else if(count > 1 && _charsToSplit2.Contains(splitedText[count - 1]) && (splitedText[count - 2] == ' ' || splitedText[count - 2] == '-'))
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

            var sb = new StringBuilder();
            foreach(var character in input)
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

        /// <summary>
        /// Uppercase the first character
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>New string</returns>
        public static string UppercaseFirst(this string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            var charArray = input.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        /// <summary>
        /// Transform first character of the text to lower
        /// </summary>
        /// <param name="input">Text to be transformed</param>
        /// <returns>Text transformed</returns>
        public static string LowercaseFirst(this string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            var charArray = input.ToCharArray();
            charArray[0] = char.ToLower(charArray[0]);
            return new string(charArray);
        }

        /// <summary>
        /// Convert a text to snake case format
        /// </summary>
        /// <param name="input">Text to be transformed</param>
        /// <returns>Text transformed</returns>
        public static string ToSnakeCase(this string input)
        { // Reference1: https://stackoverflow.com/questions/63055621/how-to-convert-camel-case-to-snake-case-with-two-capitals-next-to-each-other
          // Reference1: https://github.com/efcore/EFCore.NamingConventions/blob/main/EFCore.NamingConventions/Internal/SnakeCaseNameRewriter.cs
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            var builder = new StringBuilder(input.Length + Math.Min(2, input.Length / 5));
            var previousCategory = default(UnicodeCategory?);

            for(var currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                var currentChar = input[currentIndex];
                if(currentChar == '_')
                {
                    builder.Append('_');
                    previousCategory = null;
                    continue;
                }

                var currentCategory = char.GetUnicodeCategory(currentChar);
                switch(currentCategory)
                {
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.TitlecaseLetter:
                        _snakeCaseHandleUppercaseLetterAndTitlecaseLetter(
                            input,
                            currentIndex,
                            previousCategory,
                            builder
                        );

                        currentChar = char.ToLower(currentChar, CultureInfo.InvariantCulture);
                        break;

                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        if(previousCategory == UnicodeCategory.SpaceSeparator)
                        {
                            builder.Append('_');
                        }
                        break;

                    default:
                        if(previousCategory != null)
                        {
                            previousCategory = UnicodeCategory.SpaceSeparator;
                        }
                        continue;
                }

                builder.Append(currentChar);
                previousCategory = currentCategory;
            }

            return builder.ToString();
        }

        private static void _snakeCaseHandleUppercaseLetterAndTitlecaseLetter(string input, int currentIndex, UnicodeCategory? previousCategory, StringBuilder builder)
        {
            if(previousCategory == UnicodeCategory.SpaceSeparator ||
                previousCategory == UnicodeCategory.LowercaseLetter ||
                (previousCategory != UnicodeCategory.DecimalDigitNumber &&
                previousCategory != null &&
                currentIndex > 0 &&
                currentIndex + 1 < input.Length &&
                char.IsLower(input[currentIndex + 1])))
            {
                builder.Append('_');
            }
        }
    }
}
