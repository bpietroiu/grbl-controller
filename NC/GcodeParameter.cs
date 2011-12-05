using System.Runtime.InteropServices;

namespace GCodeStreamer.NC
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GcodeParameter
    {
        public override string ToString()
        {
            return string.Format("{0}{1}", OpCode, Value);
        }

        public GcodeOpCode.OpCodes OpCode;
        public double Value;
        public GcodeParameter(GcodeOpCode.OpCodes opcode, double fval)
        {
            this.OpCode = opcode;
            this.Value = fval;
        }

        public GcodeParameter(string id, double fval)
            : this(GcodeOpCode.ParseOpCode(id), fval)
        {
        }

        public GcodeParameter(GcodeToken tok)
        {
            this.OpCode = GcodeOpCode.ParseOpCode(tok.ID.ToString());
            this.Value = tok.Value;
        }
    }
}