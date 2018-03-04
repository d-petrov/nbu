using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    [Export(typeof(ICalculator))]
    class SimpleCalculator : ICalculator
    {
        public String Calculate(String input)
        {
            String output = "gtfo";

            return output;
        }
    }
}
