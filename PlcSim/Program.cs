using Antlr4.Runtime;
using System;

namespace PlcSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var plc = new Plc();
            plc.BitDevices["R0"] = Plc.ON;
            plc.WordDevices["DM0"] = 10;
            plc.WordDevices["DM10"] = 0;
            plc.WordDevices["DM11"] = 0;
            plc.WordDevices["DM12"] = 100;
            plc.WordDevices["Z1"] = 2;

            //実行前の結果
            plc.DisplayCurrentDevice();
            Interpreter.Execute(plc, "LD R0\nMOV DM0 DM10:Z1");
#if false
            var ret = Interpreter.Execute(plc, "LD R0\nMOV DM0 DM10");
            plc.BitDevices["R0"] = Plc.OFF;
            plc.BitDevices["R1"] = Plc.ON;
            plc.WordDevices["DM0"] = 10;
            plc.WordDevices["DM10"] = 0;

            ret = Interpreter.Execute(plc, "LD R0\nMOV DM0 DM10");
            ret = Interpreter.Execute(plc, "LDB R0\nMOV DM0 DM10");
            ret = Interpreter.Execute(plc, "LD R1\nOUT R0");
#endif
        }
    }

    public static class Interpreter
    {
        public static Result Execute(Plc plc, string mnemonic)
        {
            Console.WriteLine("\ninput:\n" + mnemonic);
            var inputStream = new AntlrInputStream(mnemonic);
            var lexer = new testLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new testParser(tokenStream);

            try
            {
                return (new Visitor(plc)).Visit(parser.input());
            }
            finally
            {
                plc.DisplayCurrentDevice();
            }
        }
    }
}
