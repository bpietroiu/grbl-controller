using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace GCodeStreamer.NC
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GcodeToken
    {
        public char ID;
        public double Value;
        public static GcodeToken ReadToken(TextReader tr, StringBuilder errs, long linenum)
        {
            int num2;
            int num = 0;
            GcodeToken token = new GcodeToken();
            token.ID = '\uffff';
            string s = "";
            int num3 = 0;
            Label_001F:
            num2 = tr.Peek();
            ((char)num2).ToString();
            switch (num2)
            {
                case -1:
                    if (num3 == 0)
                    {
                        return token;
                    }
                    break;

                case 40:
                    if (num3 != 0)
                    {
                        break;
                    }
                    tr.Read();
                    num++;
                    token.ID = '\b';

                    goto Label_001F;

                case 0x29:
                    if (num3 == 0)
                    {
                        tr.Read();
                        num--;
                        
                        if (num < 0)
                        {
                            errs.AppendFormat("Line={0} - Comment bracket mismatch\n", linenum);
                            return token;
                        }
                        goto Label_001F;
                    }
                    break;

                default:
                    if ((num > 0) && (num3 == 0))
                    {
                        tr.Read();
                        goto Label_001F;
                    }
                    switch (num2)
                    {
                        case 0x3b:
                            tr.ReadLine();
                            if (num3 == 0)
                            {
                                token.ID = '\n';
                                return token;
                            }
                            break;

                        case 10:
                            if (num3 == 0)
                            {
                                tr.Read();
                                token.ID = (char)num2;
                                return token;
                            }
                            break;
                    }
                    if (char.IsWhiteSpace((char)num2) || char.IsControl((char)num2))
                    {
                        if (num3 != 0)
                        {
                            break;
                        }
                        tr.Read();
                        goto Label_001F;
                    }
                    if (char.IsLetter((char)num2))
                    {
                        if (num3 != 0)
                        {
                            break;
                        }
                        token.ID = char.ToUpper((char)num2);
                        tr.Read();
                        num3++;
                        goto Label_001F;
                    }
                    if ((num3 == 0) && ((char.IsDigit((char)num2) || (((ushort)num2) == 0x2d)) || (((ushort)num2) == 0x2d)))
                    {
                        token.ID = '-';
                        num3++;
                        goto Label_001F;
                    }
                    if (num3 > 0)
                    {
                        if ((num2 == 0x2d) && (num3 == 1))
                        {
                            tr.Read();
                            s = s + ((char)num2);
                            num3++;
                            goto Label_001F;
                        }
                        if (char.IsDigit((char)num2))
                        {
                            if (num3 == 1)
                            {
                                num3++;
                            }
                            tr.Read();
                            s = s + ((char)num2);
                            goto Label_001F;
                        }
                        if ((num2 == 0x2e) && (num3 < 3))
                        {
                            num3 = 3;
                            tr.Read();
                            s = s + ((char)num2);
                            goto Label_001F;
                        }
                    }
                    errs.AppendFormat("Line={0} - Unexpected token '{1}'\n", linenum, (char)num2);
                    return token;
            }
            try
            {
                token.Value = double.Parse(s);
            }
            catch
            {
                errs.AppendFormat("Line={0} - Incorrect parameter\n", linenum);
            }
            return token;
        }
    }
}