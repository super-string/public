using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcSim.Operand
{
    public class PrimitiveValue : IOperand
    {
        public bool BoolValue { get; set; }
    }
}
