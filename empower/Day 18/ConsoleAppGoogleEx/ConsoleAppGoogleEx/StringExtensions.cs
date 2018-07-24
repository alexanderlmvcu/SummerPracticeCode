using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppGoogleEx
{
    public static class StringExtensions
    {
        public static string Reverse(this string original)
        {
            return new string (original.ToCharArray().Reverse().ToArray());
        }
    }
}
