using System.Collections.Generic;
using System.Text;

namespace GCodeStreamer.NC
{
    public class GcodeOpCode
    {
        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            
            if(OpCode != OpCodes.Unknown)
                ret.Append(OpCode);

            foreach (var parameter in Parameter)
            {
                ret.AppendFormat(" {0}", parameter);
            }
            return ret.ToString().Trim();
        }

        // Fields
        public OpCodes OpCode;
        public GcodeParameter[] Parameter;
        public double Value;

        // Methods
        public GcodeOpCode()
            : this(OpCodes.Unknown)
        {
        }

        public GcodeOpCode(OpCodes opcode)
        {
            this.OpCode = opcode;
            this.Parameter = new GcodeParameter[0];
        }

        public GcodeOpCode(string id)
            : this(ParseOpCode(id))
        {
        }

        public static OpCodes ParseOpCode(string opcode)
        {
            if (opcode[0] == 'G')
            {
                string key = opcode;
                if (key != null)
                {
                    int num;

                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x35);
                    dictionary1.Add("G00", 0);
                    dictionary1.Add("G01", 1);
                    dictionary1.Add("G02", 2);
                    dictionary1.Add("G03", 3);
                    dictionary1.Add("G04", 4);
                    dictionary1.Add("G10", 5);
                    dictionary1.Add("G12", 6);
                    dictionary1.Add("G13", 7);
                    dictionary1.Add("G15", 8);
                    dictionary1.Add("G16", 9);
                    dictionary1.Add("G17", 10);
                    dictionary1.Add("G18", 11);
                    dictionary1.Add("G19", 12);
                    dictionary1.Add("G20", 13);
                    dictionary1.Add("G21", 14);
                    dictionary1.Add("G28", 15);
                    dictionary1.Add("G28.1", 0x10);
                    dictionary1.Add("G30", 0x11);
                    dictionary1.Add("G31", 0x12);
                    dictionary1.Add("G40", 0x13);
                    dictionary1.Add("G41", 20);
                    dictionary1.Add("G42", 0x15);
                    dictionary1.Add("G43", 0x16);
                    dictionary1.Add("G49", 0x17);
                    dictionary1.Add("G50", 0x18);
                    dictionary1.Add("G51", 0x19);
                    dictionary1.Add("G53", 0x1a);
                    dictionary1.Add("G54", 0x1b);
                    dictionary1.Add("G59", 0x1c);
                    dictionary1.Add("G61", 0x1d);
                    dictionary1.Add("G64", 30);
                    dictionary1.Add("G73", 0x1f);
                    dictionary1.Add("G80", 0x20);
                    dictionary1.Add("G81", 0x21);
                    dictionary1.Add("G82", 0x22);
                    dictionary1.Add("G83", 0x23);
                    dictionary1.Add("G84", 0x24);
                    dictionary1.Add("G85", 0x25);
                    dictionary1.Add("G86", 0x26);
                    dictionary1.Add("G87", 0x27);
                    dictionary1.Add("G88", 40);
                    dictionary1.Add("G89", 0x29);
                    dictionary1.Add("G90", 0x2a);
                    dictionary1.Add("G91", 0x2b);
                    dictionary1.Add("G92", 0x2c);
                    dictionary1.Add("G92.1", 0x2d);
                    dictionary1.Add("G92.2", 0x2e);
                    dictionary1.Add("G92.3", 0x2f);
                    dictionary1.Add("G93", 0x30);
                    dictionary1.Add("G94", 0x31);
                    dictionary1.Add("G95", 50);
                    dictionary1.Add("G98", 0x33);
                    dictionary1.Add("G99", 0x34);


                    if (dictionary1.TryGetValue(key, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                return OpCodes.G00;

                            case 1:
                                return OpCodes.G01;

                            case 2:
                                return OpCodes.G02;

                            case 3:
                                return OpCodes.G03;

                            case 4:
                                return OpCodes.G04;

                            case 5:
                                return OpCodes.G10;

                            case 6:
                                return OpCodes.G12;

                            case 7:
                                return OpCodes.G13;

                            case 8:
                                return OpCodes.G15;

                            case 9:
                                return OpCodes.G16;

                            case 10:
                                return OpCodes.G17;

                            case 11:
                                return OpCodes.G18;

                            case 12:
                                return OpCodes.G19;

                            case 13:
                                return OpCodes.G20;

                            case 14:
                                return OpCodes.G21;

                            case 15:
                                return OpCodes.G28;

                            case 0x10:
                                return OpCodes.G28_1;

                            case 0x11:
                                return OpCodes.G30;

                            case 0x12:
                                return OpCodes.G31;

                            case 0x13:
                                return OpCodes.G40;

                            case 20:
                                return OpCodes.G41;

                            case 0x15:
                                return OpCodes.G42;

                            case 0x16:
                                return OpCodes.G43;

                            case 0x17:
                                return OpCodes.G49;

                            case 0x18:
                                return OpCodes.G50;

                            case 0x19:
                                return OpCodes.G51;

                            case 0x1a:
                                return OpCodes.G53;

                            case 0x1b:
                                return OpCodes.G54;

                            case 0x1c:
                                return OpCodes.G59;

                            case 0x1d:
                                return OpCodes.G61;

                            case 30:
                                return OpCodes.G64;

                            case 0x1f:
                                return OpCodes.G73;

                            case 0x20:
                                return OpCodes.G80;

                            case 0x21:
                                return OpCodes.G81;

                            case 0x22:
                                return OpCodes.G82;

                            case 0x23:
                                return OpCodes.G83;

                            case 0x24:
                                return OpCodes.G84;

                            case 0x25:
                                return OpCodes.G85;

                            case 0x26:
                                return OpCodes.G86;

                            case 0x27:
                                return OpCodes.G87;

                            case 40:
                                return OpCodes.G88;

                            case 0x29:
                                return OpCodes.G89;

                            case 0x2a:
                                return OpCodes.G90;

                            case 0x2b:
                                return OpCodes.G91;

                            case 0x2c:
                                return OpCodes.G92;

                            case 0x2d:
                                return OpCodes.G92_1;

                            case 0x2e:
                                return OpCodes.G92_2;

                            case 0x2f:
                                return OpCodes.G92_3;

                            case 0x30:
                                return OpCodes.G93;

                            case 0x31:
                                return OpCodes.G94;

                            case 50:
                                return OpCodes.G95;

                            case 0x33:
                                return OpCodes.G98;

                            case 0x34:
                                return OpCodes.G99;
                        }
                    }
                }
            }
            else if (opcode[0] == 'M')
            {
                string str2 = opcode;
                if (str2 != null)
                {
                    int num2;
                    Dictionary<string, int> dictionary2 = new Dictionary<string, int>(0x10);
                    dictionary2.Add("M00", 0);
                    dictionary2.Add("M01", 1);
                    dictionary2.Add("M02", 2);
                    dictionary2.Add("M03", 3);
                    dictionary2.Add("M04", 4);
                    dictionary2.Add("M05", 5);
                    dictionary2.Add("M06", 6);
                    dictionary2.Add("M07", 7);
                    dictionary2.Add("M08", 8);
                    dictionary2.Add("M09", 9);
                    dictionary2.Add("M30", 10);
                    dictionary2.Add("M47", 11);
                    dictionary2.Add("M48", 12);
                    dictionary2.Add("M49", 13);
                    dictionary2.Add("M98", 14);
                    dictionary2.Add("M99", 15);

                    if (dictionary2.TryGetValue(str2, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                return OpCodes.M00;

                            case 1:
                                return OpCodes.M01;

                            case 2:
                                return OpCodes.M02;

                            case 3:
                                return OpCodes.M03;

                            case 4:
                                return OpCodes.M04;

                            case 5:
                                return OpCodes.M05;

                            case 6:
                                return OpCodes.M06;

                            case 7:
                                return OpCodes.M07;

                            case 8:
                                return OpCodes.M08;

                            case 9:
                                return OpCodes.M09;

                            case 10:
                                return OpCodes.M30;

                            case 11:
                                return OpCodes.M47;

                            case 12:
                                return OpCodes.M48;

                            case 13:
                                return OpCodes.M49;

                            case 14:
                                return OpCodes.M98;

                            case 15:
                                return OpCodes.M99;
                        }
                    }
                }
            }
            else
            {
                string str3 = opcode;
                if (str3 != null)
                {
                    int num3;

                    Dictionary<string, int> dictionary3 = new Dictionary<string, int>(0x17);
                    dictionary3.Add("A", 0);
                    dictionary3.Add("B", 1);
                    dictionary3.Add("C", 2);
                    dictionary3.Add("D", 3);
                    dictionary3.Add("F", 4);
                    dictionary3.Add("G", 5);
                    dictionary3.Add("H", 6);
                    dictionary3.Add("I", 7);
                    dictionary3.Add("J", 8);
                    dictionary3.Add("K", 9);
                    dictionary3.Add("L", 10);
                    dictionary3.Add("M", 11);
                    dictionary3.Add("N", 12);
                    dictionary3.Add("O", 13);
                    dictionary3.Add("P", 14);
                    dictionary3.Add("Q", 15);
                    dictionary3.Add("R", 0x10);
                    dictionary3.Add("S", 0x11);
                    dictionary3.Add("T", 0x12);
                    dictionary3.Add("X", 0x13);
                    dictionary3.Add("Y", 20);
                    dictionary3.Add("Z", 0x15);
                    dictionary3.Add("-", 0x16);

                    if (dictionary3.TryGetValue(str3, out num3))
                    {
                        switch (num3)
                        {
                            case 0:
                                return OpCodes.A;

                            case 1:
                                return OpCodes.B;

                            case 2:
                                return OpCodes.C;

                            case 3:
                                return OpCodes.D;

                            case 4:
                                return OpCodes.F;

                            case 5:
                                return OpCodes.G;

                            case 6:
                                return OpCodes.H;

                            case 7:
                                return OpCodes.I;

                            case 8:
                                return OpCodes.J;

                            case 9:
                                return OpCodes.K;

                            case 10:
                                return OpCodes.L;

                            case 11:
                                return OpCodes.M;

                            case 12:
                                return OpCodes.N;

                            case 13:
                                return OpCodes.O;

                            case 14:
                                return OpCodes.P;

                            case 15:
                                return OpCodes.Q;

                            case 0x10:
                                return OpCodes.R;

                            case 0x11:
                                return OpCodes.S;

                            case 0x12:
                                return OpCodes.T;

                            case 0x13:
                                return OpCodes.X;

                            case 20:
                                return OpCodes.Y;

                            case 0x15:
                                return OpCodes.Z;

                            case 0x16:
                                return OpCodes.Number;
                        }
                    }
                }
            }
            return OpCodes.Unknown;
        }

        // Nested Types
        public enum OpCodes
        {
            Unknown,
            G00,
            G01,
            G02,
            G03,
            G04,
            G10,
            G12,
            G13,
            G15,
            G16,
            G17,
            G18,
            G19,
            G20,
            G21,
            G28,
            G28_1,
            G30,
            G31,
            G40,
            G41,
            G42,
            G43,
            G49,
            G50,
            G51,
            G53,
            G54,
            G59,
            G61,
            G64,
            G73,
            G80,
            G81,
            G82,
            G83,
            G84,
            G85,
            G86,
            G87,
            G88,
            G89,
            G90,
            G91,
            G92,
            G92_1,
            G92_2,
            G92_3,
            G93,
            G94,
            G95,
            G98,
            G99,
            M00,
            M01,
            M02,
            M03,
            M04,
            M05,
            M06,
            M07,
            M08,
            M09,
            M30,
            M47,
            M48,
            M49,
            M98,
            M99,
            A,
            B,
            C,
            D,
            F,
            G,
            H,
            I,
            J,
            K,
            L,
            M,
            N,
            O,
            P,
            Q,
            R,
            S,
            T,
            X,
            Y,
            Z,
            Number
        }
    }
}