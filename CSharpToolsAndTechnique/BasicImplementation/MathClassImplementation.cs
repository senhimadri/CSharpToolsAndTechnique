using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.BasicImplementation
{
    public static class MathClassImplementation
    {

        public static void MathVoidMethods()
        {
            Decimal _DesVal = -1.586M;

            decimal _returnDtatement = 0;

            // Abs()	Returns the absolute value of a specified number.
            _returnDtatement=Math.Abs(_DesVal);


            // Acos()	Returns the angle whose cosine is the specified number.


            Console.WriteLine(_returnDtatement);


        }
    }
}
