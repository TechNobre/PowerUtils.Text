using System;
using System.Text.RegularExpressions;

namespace PowerUtils.Text
{
    internal static partial class RegexUtils
    {
        private const string TAB_PATTERN = "\t";
        private const string MULTI_SPACES_PATTERN = " +";
        private const string SPACE_AFTER_LINE_BREAK_PATTERN = @"(\r\n?|\n) ";
        private const string SPACE_BEFORE_LINE_BREAK_PATTERN = @" (\r\n?|\n)";
        private const string MULTI_LINE_BREAK_PATTERN = @"(\r\n?|\n)+";

        private const string EMAIL_PATTERN = @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)+$";

        private static readonly TimeSpan _regexTimout = TimeSpan.FromMilliseconds(100);


#if NET7_0_OR_GREATER
        [GeneratedRegex(TAB_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex TabRegex();

        [GeneratedRegex(MULTI_SPACES_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex MultiSpaceRegex();

        [GeneratedRegex(SPACE_AFTER_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex SpaceAfterLineBreakRegex();

        [GeneratedRegex(SPACE_BEFORE_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex SpaceBeforeLineBreakRegex();

        [GeneratedRegex(MULTI_LINE_BREAK_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex MultiLineBreakRegex();

        [GeneratedRegex(EMAIL_PATTERN, RegexOptions.Compiled)]
        internal static partial Regex EmailRegex();
#else
        private static readonly Regex _tabRegex = new Regex(TAB_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex TabRegex() => _tabRegex;


        private static readonly Regex _multiSpaceRegex = new Regex(MULTI_SPACES_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex MultiSpaceRegex() => _multiSpaceRegex;


        private static readonly Regex _spaceAfterLineBreakRegex = new Regex(SPACE_AFTER_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex SpaceAfterLineBreakRegex() => _spaceAfterLineBreakRegex;


        private static readonly Regex _spaceBeforeLineBreakRegex = new Regex(SPACE_BEFORE_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex SpaceBeforeLineBreakRegex() => _spaceBeforeLineBreakRegex;


        private static readonly Regex _multiLineBreakRegex = new Regex(MULTI_LINE_BREAK_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex MultiLineBreakRegex() => _multiLineBreakRegex;


        private static readonly Regex _emailRegex = new Regex(EMAIL_PATTERN, RegexOptions.Compiled, _regexTimout);
        internal static Regex EmailRegex() => _emailRegex;
#endif
    }
}
