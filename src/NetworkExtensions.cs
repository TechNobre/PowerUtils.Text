using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace PowerUtils.Text
{
    /// <summary>
    /// Extensions for network strings
    /// </summary>
    public static partial class NetworkExtensions
    {
#if NET7_0_OR_GREATER
        [GeneratedRegex(@"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)+$", RegexOptions.Compiled)]
        private static partial Regex _emailRegex();
#else
        private static readonly Regex _emailRegex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)+$", RegexOptions.Compiled, TimeSpan.FromMilliseconds(200));
#endif


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


#if NET7_0_OR_GREATER
            return _emailRegex().IsMatch(email);
#else
            return _emailRegex.IsMatch(email);
#endif
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

        /// <summary>
        /// Convert an object to a QueryString
        /// </summary>
        /// <param name="parameters">Object with parameters</param>
        /// <returns>QueryString</returns>
        /// <exception cref="ArgumentNullException">When the <paramref name="parameters">parameters</paramref> is null</exception>
        /// <exception cref="NotSupportedException">When the <paramref name="parameters">parameters</paramref> is of the type not supported</exception>
        public static string ToQueryString<T>(this T parameters) where T : new()
        {
            if(parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters), "The parameters cannot be null");
            }

            var type = parameters.GetType();
            if( // Not supported types
                type != typeof(short) &&
                type != typeof(ushort) &&
                type != typeof(int) &&
                type != typeof(uint) &&
                type != typeof(long) &&
                type != typeof(ulong) &&
                type != typeof(float) &&
                type != typeof(double) &&
                type != typeof(decimal))
            {
                var properties = parameters
                    .GetType().GetProperties()
                    .Where(w => w.GetValue(parameters, null) != null)
                    .Select(s => $"{s.Name}={HttpUtility.UrlEncode(s.GetValue(parameters, null).ToString())}");

                if(!properties.Any())
                {
                    return "";
                }

                return $"?{string.Join("&", properties)}";
            }


            throw new NotSupportedException($"The type {type.Name} is not supported");
        }
    }
}
