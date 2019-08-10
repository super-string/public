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

            //実行前の結果
            plc.DisplayCurrentDevice();

            var ret = Interpreter.Execute(plc, "LD R0\nMOV DM0 DM10");
            if(!ret.Success)
            {
                Console.WriteLine(ret.Message);
                return;
            }

            //実行後の結果
            plc.DisplayCurrentDevice();


            plc.BitDevices["R0"] = Plc.OFF;
            plc.WordDevices["DM0"] = 10;
            plc.WordDevices["DM10"] = 0;

            plc.DisplayCurrentDevice();

        }
    }

    public static class Interpreter
    {
        public static Result Execute(Plc plc, string mnemonic)
        {
            var inputStream = new AntlrInputStream(mnemonic);
            var lexer = new testLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new testParser(tokenStream);

            return (new Visitor(plc)).Visit(parser.input());
        }
    }
}
