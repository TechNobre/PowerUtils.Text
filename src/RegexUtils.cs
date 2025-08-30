using System;
using System.Text.RegularExpressions;

namespace PowerUtils.Text
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    internal static partial class RegexUtils
    {
        private const string TAB_PATTERN = "\t";
        private const string MULTI_SPACES_PATTERN = " +";
        private const string SPACE_AFTER_LINE_BREAK_PATTERN = @"(\r\n?|\n) ";
        private const string SPACE_BEFORE_LINE_BREAK_PATTERN = @" (\r\n?|\n)";
        private const string MULTI_LINE_BREAK_PATTERN = @"(\r\n?|\n)+";

        private const string EMAIL_PATTERN = @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)+$";


#if NET7_0_OR_GREATER
        [GeneratedRegex(TAB_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _tabRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex TabRegex => _tabRegex();


        [GeneratedRegex(MULTI_SPACES_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _multiSpaceRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex MultiSpaceRegex => _multiSpaceRegex();


        [GeneratedRegex(SPACE_AFTER_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _spaceAfterLineBreakRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex SpaceAfterLineBreakRegex => _spaceAfterLineBreakRegex();


        [GeneratedRegex(SPACE_BEFORE_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _spaceBeforeLineBreakRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex SpaceBeforeLineBreakRegex => _spaceBeforeLineBreakRegex();


        [GeneratedRegex(MULTI_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _multiLineBreakRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex MultiLineBreakRegex => _multiLineBreakRegex();


        [GeneratedRegex(EMAIL_PATTERN, RegexOptions.Compiled)]
        private static partial Regex _emailRegex();
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static Regex EmailRegex => _emailRegex();
#else
        private static readonly TimeSpan _regexTimout = TimeSpan.FromMilliseconds(100);


        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex TabRegex = new Regex(TAB_PATTERN, RegexOptions.Compiled, _regexTimout);
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex MultiSpaceRegex = new Regex(MULTI_SPACES_PATTERN, RegexOptions.Compiled, _regexTimout);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex SpaceAfterLineBreakRegex = new Regex(SPACE_AFTER_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex SpaceBeforeLineBreakRegex = new Regex(SPACE_BEFORE_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex MultiLineBreakRegex = new Regex(MULTI_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static readonly Regex EmailRegex = new Regex(EMAIL_PATTERN, RegexOptions.Compiled, _regexTimout);
#endif
    }
}
