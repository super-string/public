using PlcSim.Operand;

namespace PlcSim.Operand
{
    public class Device : IOperand
    {
        public DeviceCode Code { get; }
        public uint Address { get; }
        public DevAttribute Attribute { get; private set; }

        private Device(DeviceCode code, uint address)
        {
            Code = code;
            Address = address;
        }

        public static bool TryParse(string input, out Device device)
        {
            //パースは簡素にする。
            foreach (var key in DeviceTable.Table.Keys)
            {
                if (input.StartsWith(key))
                {
                    var code = DeviceTable.Table[key].Code;
                    uint address;
                    if (!uint.TryParse(input.Replace(key, string.Empty), out address))
                    {
                        device = new Device(DeviceCode.None, 0);
                        return false;
                    }

                    device = new Device(code, address) { Attribute = DeviceTable.Table[key] };
                    return true;
                }
            }
            device = new Device(DeviceCode.None, 0);
            return false;
        }
    }
}
