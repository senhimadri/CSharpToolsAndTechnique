using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.DelegatesAndEvents
{
    internal class DelegateExercisesThree
    {
        public delegate void MyDeligates();

        void MethodOne(int i)
        {
            Console.WriteLine("Method One with parameter. ");
        }

        public void MethodTwo()
        {
            //MyDeligates myDeligates = new MyDeligates(MethodOne);
        }
    }
}
