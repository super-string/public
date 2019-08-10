using PlcSim.Operand;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PlcSim
{
    public class Plc
    {
        public const bool ON = true;
        public const bool OFF = false;

        private Stack<bool> _inputInstStack = new Stack<bool>();

        public Dictionary<string, bool> BitDevices { get; } = new Dictionary<string, bool>();
        public Dictionary<string, ushort> WordDevices { get; } = new Dictionary<string, ushort>();

        public void PushInputState(bool state)
        {
            _inputInstStack.Push(state);
        }

        public void ClearInputState()
        {
            _inputInstStack.Clear();
        }

        public bool CanOutput()
        {
            return _inputInstStack.All(_ => _);
        }

        public string FindKey(Device target)
        {
            foreach (var key in BitDevices.Keys)
            {
                Device device;
                if (Device.TryParse(key, out device))
                {
                    if (target.Code == device.Code && target.Address == device.Address)
                    {
                        return key;
                    }
                }
            }
            foreach (var key in WordDevices.Keys)
            {
                Device device;
                if (Device.TryParse(key, out device))
                {
                    if (target.Code == device.Code && target.Address == device.Address)
                    {
                        return key;
                    }
                }
            }
            return string.Empty;
        }

        public void DisplayCurrentDevice()
        {
            Console.WriteLine("----------------------------------");
            foreach (var key in BitDevices.Keys)
            {
                Console.WriteLine(key + "\t" + (BitDevices[key] ? "ON" : "OFF"));
            }
            foreach (var key in WordDevices.Keys)
            {
                Console.WriteLine(key + "\t" + WordDevices[key].ToString());
            }
        }
    }
}
