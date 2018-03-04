using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol","+")]
    class Addition : IOperation
    {
        public int Operate(int left, int right)
        {
            return left + right;
        }
    }
}
