using PlcSim.Operand;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PlcSim
{

    public enum Direction
    {
        In,
        Out
    }

    public class Instruction
    {
        public string Name { get; set; }
        public InstAttribute Attribute { get; set; }
    }

    public class InstAttribute
    {
        public string Name { get; set; }
        public DevType Type { get; set; }
        public Direction Dir { get; set; }
        public int AcceptArgNum { get; set; }
        public Func<Plc, IEnumerable<IOperand>, bool> Func { get; set; }
    }
    public static class InstTable
    {
        public static IDictionary<string, InstAttribute> Table => _table;
        private static Dictionary<string, InstAttribute> _table = new Dictionary<string, InstAttribute>
        {
            {"LD", new InstAttribute { Name = "LD", Type = DevType.Bit, Dir = Direction.In, AcceptArgNum = 1, Func = Load } },
            {"LDB", new InstAttribute { Name = "LDB", Type = DevType.Bit, Dir = Direction.In, AcceptArgNum = 1, Func = LoadB } },
            {"OUT", new InstAttribute { Name = "OUT", Type = DevType.Bit, Dir = Direction.Out, AcceptArgNum = 1, Func = Out } },
            {"MOV", new InstAttribute { Name = "MOV", Type = DevType.Word, Dir = Direction.Out, AcceptArgNum = 2, Func = Move } },
        };

        private static bool Load(Plc plc, IEnumerable<IOperand> operands)
        {
            return LoadCore(plc, operands, false);
        }
        private static bool LoadB(Plc plc, IEnumerable<IOperand> operands)
        {
            return LoadCore(plc, operands, true);
        }

        private static bool LoadCore(Plc plc, IEnumerable<IOperand> operands, bool b)
        {
            if (operands.Count() != 1)
                throw new ArgumentOutOfRangeException("operands");

            var device = operands.First() as Device;
            if (device == null)
                throw new InvalidCastException();

            var plcDevice = plc.FindKey(device);
            if (string.IsNullOrEmpty(plcDevice))
                throw new InvalidOperationException();

            return b ? !plc.BitDevices[plcDevice] : plc.BitDevices[plcDevice];
        }

        private static bool Out(Plc plc, IEnumerable<IOperand> operands)
        {
            if (operands.Count() != 1)
                throw new ArgumentOutOfRangeException("operands");

            var device = operands.First() as Device;
            if (device == null)
                throw new InvalidCastException();

            var plcDevice = plc.FindKey(device);
            if (string.IsNullOrEmpty(plcDevice))
                throw new InvalidOperationException();

            plc.BitDevices[plcDevice] = true;
            return true;
        }

        private static bool Move(Plc plc, IEnumerable<IOperand> operands)
        {
            if (operands.Count() != 2)
                throw new ArgumentOutOfRangeException("operands");

            var srcDevice = operands.ElementAt(0) as Device;
            var dstDevice = operands.ElementAt(1) as Device;
            if (srcDevice == null || dstDevice == null)
                throw new InvalidCastException();

            var srcPlcDevice = plc.FindKey(srcDevice);
            var dstPlcDevice = plc.FindKey(dstDevice);
            if (string.IsNullOrEmpty(srcPlcDevice) || (string.IsNullOrEmpty(dstPlcDevice)))
                throw new InvalidOperationException();

            plc.WordDevices[dstPlcDevice] = plc.WordDevices[srcPlcDevice];

            return true;
        }
    }
}
