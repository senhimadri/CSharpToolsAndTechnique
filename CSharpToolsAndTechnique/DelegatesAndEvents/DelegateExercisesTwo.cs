using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.DelegatesAndEvents
{
    internal class DelegateExercisesTwo
    {
        public delegate void Mydeligate();
        void MethodOne()
        {
            Console.WriteLine("Method One");
            Console.ReadLine();

        }

        public void MethiodTwo()
        {
            Mydeligate mydeligate = new Mydeligate(MethodOne);
            //deligate(50);
        }


    }
}
