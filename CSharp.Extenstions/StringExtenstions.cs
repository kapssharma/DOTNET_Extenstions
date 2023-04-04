using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Extenstions
{
    public static class StringExtenstions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
