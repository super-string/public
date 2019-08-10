using PlcSim.Operand;
using System.Collections.Generic;

namespace PlcSim.Operand
{
    public static class DeviceTable
    {
        public static IDictionary<string, DevAttribute> Table => _table;
        private static Dictionary<string, DevAttribute> _table = new Dictionary<string, DevAttribute>
        {
            {"R", new DevAttribute { Code = DeviceCode.R, Type = DevType.Bit} },
            {"X", new DevAttribute { Code = DeviceCode.R, Type = DevType.Bit} },
            {"Y", new DevAttribute { Code = DeviceCode.R, Type = DevType.Bit} },
            {"DM", new DevAttribute { Code = DeviceCode.DM, Type = DevType.Word} },
            {"D", new DevAttribute { Code = DeviceCode.DM, Type = DevType.Word} },
        };
    }
}
