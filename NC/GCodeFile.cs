using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace GCodeStreamer.NC
{
    public class GCodeFile
    {
        // Fields
        public double A;
        public DistanceModes ArcCenterMode = DistanceModes.Incremental;
        public double B;
        public double C;
        public DistanceModes DistanceMode = DistanceModes.Absolute;
        public double F;
        public GcodeOpCode[] GCodes = null;
        public double I;
        public double J;
        public double X;
        public double Y;
        public double Z;

        // Methods
        public void ReadTextStream(TextReader tr, StringBuilder errs)
        {
            GcodeOpCode code = null;
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            long linenum = 1L;
            while (true)
            {
                GcodeToken token;
                do
                {
                    token = GcodeToken.ReadToken(tr, errs, linenum);
                    if (token.ID == 0xffff)
                    {
                        if (code != null)
                        {
                            code.Parameter = (GcodeParameter[])list2.ToArray(typeof(GcodeParameter));
                            list.Add(code);
                        }
                        goto Label_0150;
                    }
                }
                while (token.ID == 'N');
                if (token.ID == '\n')
                {
                    linenum += 1L;
                    if (code != null)
                    {
                        code.Parameter = (GcodeParameter[])list2.ToArray(typeof(GcodeParameter));
                        list.Add(code);
                        code = null;
                    }
                }
                else if ((token.ID == 'G') || (token.ID == 'M'))
                {
                    if (code != null)
                    {
                        code.Parameter = (GcodeParameter[])list2.ToArray(typeof(GcodeParameter));
                        list.Add(code);
                    }
                    code = new GcodeOpCode(string.Format("{0}{1:02}", token.ID, token.Value.ToString("00")));
                    list2.Clear();
                }
                else
                {
                    if (code == null)
                    {
                        code = new GcodeOpCode(GcodeOpCode.OpCodes.Unknown);
                    }
                    GcodeParameter parameter = new GcodeParameter(token);
                    if (parameter.OpCode != GcodeOpCode.OpCodes.Unknown)
                    {
                        list2.Add(parameter);
                    }
                }
            }
        Label_0150:
            this.GCodes = (GcodeOpCode[])list.ToArray(typeof(GcodeOpCode));
        }
    }
}
