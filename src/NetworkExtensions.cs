using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PowerUtils.Text
{
    /// <summary>
    /// Extensions for network strings
    /// </summary>
    public static class NetworkExtensions
    {
        private static readonly Regex _emailRegex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)+$", RegexOptions.Compiled);

        /// <summary>
        /// Check if the input is an email
        /// </summary>
        /// <param name="email">String to check</param>
        /// <returns>If it is an email</returns>
        public static bool IsEmail(this string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return _emailRegex.IsMatch(email);
        }

        /// <summary>
        /// Combine root URL with segments
        /// </summary>
        /// <param name="root">Root URL</param>
        /// <param name="segments">Next segments of the URL</param>
        /// <returns>Combined URL</returns>
        /// <exception cref="ArgumentException">When the <paramref name="root">root</paramref> is null or WhiteSpace</exception>
        public static string CombineURL(this string root, params string[] segments)
        {
            const char URL_SEPARATOR = '/';

            if(string.IsNullOrWhiteSpace(root))
            {
                throw new ArgumentException("The root URL cannot be null or WhiteSpace", nameof(root));
            }

            if(segments == null)
            {
                return root;
            }

            if(segments.Length == 0)
            {
                return root;
            }


            var paths = new StringBuilder();
            paths.Append(root);
            paths.Append(URL_SEPARATOR);

            for(var count = 0; count < segments.Length; count++)
            {
                if(string.IsNullOrWhiteSpace(segments[count]))
                {
                    continue;
                }

                paths.Append(segments[count]);
                paths.Append(URL_SEPARATOR);
            }


            return paths.ToString().TrimEnd(URL_SEPARATOR);
        }
    }
}
