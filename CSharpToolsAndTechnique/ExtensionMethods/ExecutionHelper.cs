using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.ExtensionMethods
{
    public static class ExecutionHelper
    {
        public static string StringSubstruction(this String _thisStrin, int Length)
        {
            var Res = _thisStrin.Substring(0, Length);

            var ha2 = _thisStrin.AsSpan(0, Length);
            return Res;
        }

    }
}
