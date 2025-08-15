

using System.Runtime.CompilerServices;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace _15lab.extensions
{
    internal static class StringExtensions
    {
        public static string Capitalize ( string words)
        {
            if (string.IsNullOrEmpty(words))
                return "false ";
            return char.ToUpper (words[0]) + words.Substring (1).ToLower ();
        }
        public static string ToUpperWords ( this string word )
        {
            
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            return string.Join(" ", words);
        }
    }
}
