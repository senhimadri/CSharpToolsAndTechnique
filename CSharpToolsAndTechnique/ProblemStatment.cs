using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique
{
    public class ProblemStatment
    {

        public int WithStatment()
        {
            var Banana = new
            {
                Name = "Banana",
                Price = 120
            };

            var BananaonDiscount = Banana with
            {
                Price = 99
            };

            return 1;
        }
    }
}
