using Antlr4.Runtime.Misc;
using PlcSim.Operand;
using System.Collections.Generic;

namespace PlcSim
{
    public class Result
    {
        public bool Success { get; }
        public string Message { get; }
        public object Tag { get; set; }

        public static Result CreateSuccess(object tag)
        {
            return new Result(true, string.Empty) { Tag = tag };
        }
        public static Result CreateError(string message)
        {
            return new Result(false, message);
        }

        private Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
    public class Visitor : testBaseVisitor<Result>
    {
        private readonly Plc _plc;
        public Visitor(Plc plc)
        {
            _plc = plc;
        }
        public override Result VisitInput([NotNull] testParser.InputContext context)
        {
            var mnemonic = context.mnemonic();
            foreach (var m in mnemonic)
            {
                var ret = Visit(m);
                if (!ret.Success) return ret;
            }

            return Result.CreateSuccess(null);
        }

        #region mnemonic
        public override Result VisitMnemonic_instonly([NotNull] testParser.Mnemonic_instonlyContext context)
        {
            return base.VisitMnemonic_instonly(context);
        }

        public override Result VisitMnemonic_inst([NotNull] testParser.Mnemonic_instContext context)
        {
            // 命令後
            var instRet = Visit(context.inst());
            if (!instRet.Success) return instRet;

            //オペランド
            var operands = new List<IOperand>();
            foreach (var item in context.operand())
            {
                var ret = Visit(item);
                if (!ret.Success) return ret;
                operands.Add(ret.Tag as IOperand);
            }

            var inst = instRet.Tag as Instruction;
            //まずは入力検証
            {
                //命令後に対する引数の数
                if (inst.Attribute.AcceptArgNum != operands.Count) return Result.CreateError("引数の数が不正");

                //デバイスの種別(これは仕様がよくわからない)

                //オペランドの種類
            }

            //命令後実行
            {
                if (inst.Attribute.Dir == Direction.In)
                {
                    _plc.PushInputState(inst.Attribute.Func(_plc, operands));
                }
                if (inst.Attribute.Dir == Direction.Out)
                {
                    if (_plc.CanOutput())
                    {
                        inst.Attribute.Func(_plc, operands);
                    }
                    _plc.ClearInputState();
                }
            }
            return Result.CreateSuccess(null);
        }

        public override Result VisitMnemonic_comment([NotNull] testParser.Mnemonic_commentContext context)
        {
            return base.VisitMnemonic_comment(context);
        }
        #endregion

        #region inst
        public override Result VisitInst([NotNull] testParser.InstContext context)
        {
            var ident = context.IDENT();
            var inst = ident.GetText().ToUpper();

            if (!InstTable.Table.ContainsKey(inst))
            {
                return Result.CreateError("未知の命令後");
            }

            var suffix = context.SUFFIX();
            if (suffix != null)
            {
                //サフィックス
            }

            return Result.CreateSuccess(new Instruction { Name = inst, Attribute = InstTable.Table[inst] });
        }
        #endregion

        #region operand
        #endregion

        #region device
        public override Result VisitDevice([NotNull] testParser.DeviceContext context)
        {
            var ident = context.IDENT();
            var deviceStr = ident.GetText().ToUpper();

            Device device;
            if (!Device.TryParse(deviceStr, out device))
            {
                return Result.CreateError("解析できなかったデバイス:" + deviceStr);
            }

            return Result.CreateSuccess(device);
        }
        #endregion
    }
}
