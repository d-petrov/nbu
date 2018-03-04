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
        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationData>> operations;

        public String Calculate(String input, Operation operation)
        {
            String output = "gtfo";
            foreach(Lazy<IOperation, IOperationData> o in operations)
            {
                if (o.Metadata.Symbol.Equals(operation.Symbol))
                {
                    return o.Value.Operate(operation.Left, operation.Right).ToString();
                }
            }

            return output;
        }
    }
}
