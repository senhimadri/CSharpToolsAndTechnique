using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.LinkedInTips
{
    public class AvoudUsingToUpperToLower
    {
        public bool AreStringEqual_TraditionalWay(string FirstString,string SecondString)
        {
            return (FirstString.ToUpper() == SecondString.ToUpper());
        }

        public bool AreStringEqual_New(string FirstString, string SecondString)
        {
            return String.Equals(FirstString, SecondString,StringComparison.OrdinalIgnoreCase);
        }
    }
}
