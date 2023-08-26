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
            var _stringArray = _string.ToCharArray();
            Array.Reverse(_stringArray);
            return new string(_stringArray);
        }
    }
}
