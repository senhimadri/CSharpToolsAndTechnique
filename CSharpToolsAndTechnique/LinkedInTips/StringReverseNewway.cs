using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.LinkedInTips
{
    public static class StringReverseNewway
    {
        public static string StringReverse(this string _string)
        {
            // Convert String as String Array
            var _stringArray = _string.ToCharArray();
            // Reverse Array
            Array.Reverse(_stringArray);
            // Aggrigate Array to String
            return new string(_stringArray);
        }
    }
}
