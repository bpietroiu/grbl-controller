using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GCodeStreamer.NC;

namespace grblui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateIncrement(btnMul_5, EventArgs.Empty);
            updateFeed(btnF200, EventArgs.Empty);
            updateMoveType(btnG0, EventArgs.Empty);
        }

        private void sevenSegmentArray2_Load(object sender, EventArgs e)
        {

        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private int totalBlocks = 0;
        private int usedblocks = 0;

        object syncRoot = new object();

        private void UpdateStatus()
        {
            if(port.IsOpen)
            {
                string response;
                lock (syncRoot)
                {
                    port.WriteLine("?");
                    response = port.ReadLine();
                    port.ReadLine(); // ok
                }

                var strings = response.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, string> responseDic = strings.Select(s => s.Split("=".ToCharArray(), 2)).ToDictionary(split => split[0], split => split[1]);

                //byte []dataX = new byte[4];
                //byte []dataY = new byte[4];
                //byte []dataZ = new byte[4];
                //port.WriteLine("??");

                //port.Read(dataX, 0, 4);
                //port.Read(dataY, 0, 4);
                //port.Read(dataZ, 0, 4);
                //var readLine = port.ReadLine();
                
                //double dX = BitConverter.ToSingle(dataX, 0);
                //double dY = BitConverter.ToSingle(dataY, 0);
                //double dZ = BitConverter.ToSingle(dataZ, 0);


                if (responseDic.ContainsKey("x"))
                    dspX.Value = responseDic["x"];
                if (responseDic.ContainsKey("y"))
                    dspY.Value = responseDic["y"];
                if (responseDic.ContainsKey("z"))
                    dspZ.Value = responseDic["z"];

                if (responseDic.ContainsKey("UB"))
                    usedblocks = Convert.ToInt32(responseDic["UB"]);

                if (responseDic.ContainsKey("TB"))
                    totalBlocks = Convert.ToInt32(responseDic["TB"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
            {
                statusTimer.Enabled = false;
                port.Close();
                btnConnect.BackColor = Color.Lime;
            }
            else
            {
                btnConnect.BackColor = Color.Red;
                Application.DoEvents();
                port.PortName = "COM10";
                port.NewLine = "\n";
                port.Open();

                btnConnect.BackColor = Color.Lime;
                while(port.BytesToRead > 0)
                {
                    port.ReadLine();
                    Application.DoEvents();
                }
                statusTimer.Enabled = true;
                if (ConnectedChanged != null)
                    ConnectedChanged(this, EventArgs.Empty);
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            var increment = Convert.ToInt32((sender as Control).Tag);
            SendCommand(string.Format("G21"));
            SendCommand(string.Format("G91"));
            SendCommand(string.Format("{0} Y{1} F{2}", moveType, increment * multiplier, feedRate));
            SendCommand(string.Format("G90"));
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            var increment = Convert.ToInt32((sender as Control).Tag);
            SendCommand(("G21"));
            SendCommand(("G91"));
            SendCommand(string.Format("{0} X{1} F{2}", moveType, increment * multiplier, feedRate));
            SendCommand(("G90"));
        }

        bool SendCommand(string cmd, params object[] args)
        {
            return SendCommand(string.Format(cmd, args));
        }

        bool SendCommand(string cmd)
        {
            port.WriteLine(cmd);
            return port.ReadLine().ToLower().Trim() == "ok";
        }

        private double multiplier;
        Control[] MultiplierCtrls  
        {
            get { return new Control[] { btnMul001, btnMul005, btnMul01, label4btnMul05, btnMul5, btnMul1, btnMul_5, btnMul_1, btnMul10, btnMul50 }; }
        }


        Control[] FCtrls
        {
            get { return new Control[] {btnF1, btnF5, btnF10, btnF50, btnF100, btnF150, btnF200, btnF250, btnF300, btnF400, btnF500}; }
        }

        private void UpdateIncrement(object sender, EventArgs e)
        {
            multiplier = Convert.ToDouble((sender as Control).Text);

            foreach (var ctrl in MultiplierCtrls)
            {
                if (ctrl == sender)
                    ctrl.BackColor = Color.Red;
                else
                    ctrl.BackColor = Color.Lime;
            }
        }

        

        private void btnZ_Click(object sender, EventArgs e)
        {
            var increment = Convert.ToInt32((sender as Control).Tag);
            SendCommand(("G21"));
            SendCommand(("G91"));
            SendCommand(string.Format("{0} Z{1} F{2}", moveType, increment * multiplier, feedRate));
            SendCommand(("G90"));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var fileStream = File.OpenRead(@"C:\Users\Bogdan\eagle\l298_PM\channel_PM.top.drill.tap");
            StreamReader sr = new StreamReader(fileStream);

            GCodeFile file = new GCodeFile();
            StringBuilder errs = new StringBuilder();
            file.ReadTextStream(sr, errs);
            Application.DoEvents();

            Stopwatch sw = Stopwatch.StartNew();

            foreach (var op in file.GCodes)
            {
                UpdateStatus();

                while(totalBlocks - 1 == usedblocks)
                    Application.DoEvents();

                string line = op.ToString();

                Console.WriteLine(line);
                switch (op.OpCode)
                {
                    case GcodeOpCode.OpCodes.M06:
                        {
                            //Console.WriteLine("Change Tool Please ({0})", line);
                            //Console.ReadLine();
                            continue;
                        } break;
                    case GcodeOpCode.OpCodes.G04:
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(op.Parameter[0].Value));
                            continue;
                        } break;

                }

                lock(syncRoot)
                {
                    port.WriteLine(line);
                    port.ReadLine(); // ok
                }
                UpdateStatus();
                Application.DoEvents();
            }


            sw.Stop();
            port.WriteLine("X0Y0Z10");
            Application.DoEvents();

        }

        private void btnZeroY_Click(object sender, EventArgs e)
        {
            SendCommand("G92Y0");
        }

        private void btnZeroZ_Click(object sender, EventArgs e)
        {
            SendCommand("G92Z0");
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            GoToForm f = new GoToForm();
            f.X = Convert.ToDecimal(dspX.Value);
            f.Y = Convert.ToDecimal(dspY.Value);
            f.Z = Convert.ToDecimal(dspZ.Value);

            if(f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                dspX.Value = f.X.ToString();
                dspY.Value = f.Y.ToString();
                dspZ.Value = f.Z.ToString();
            }

            SendCommand("{0}X{1}Y{2}Z{3}", moveType, f.X, f.Y, f.Z);
        }

        private void btnZeroX_Click(object sender, EventArgs e)
        {
            SendCommand("G92X0");
        }

        private void btnGoToZeroZ_Click(object sender, EventArgs e)
        {
            SendCommand("{0}Z0", moveType);
        }

        private void btnGoToZeroY_Click(object sender, EventArgs e)
        {
            SendCommand("{0}Y0", moveType);
        }

        private void btnGoToZeroX_Click(object sender, EventArgs e)
        {
            SendCommand("{0}Y0", moveType);
        }

        private void btnZeroXY_Click(object sender, EventArgs e)
        {
            SendCommand("{0}X0Y0", moveType);
        }

        private void btnZeroAll_Click(object sender, EventArgs e)
        {
            SendCommand("{0}X0Y0Z0", moveType);
        }


        public bool Connected
        {
            get { return port.IsOpen; }
        }

        public event EventHandler ConnectedChanged;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if(control == btnConnect)
                    continue;

                control.DataBindings.Add("Enabled", this, "Connected");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    btnX_Click(btnXM, EventArgs.Empty);
                    break;
                case Keys.Right:
                    btnX_Click(btnXP, EventArgs.Empty);
                    break;
                case Keys.Up:
                    btnY_Click(btnYM, EventArgs.Empty);
                    break;
                case Keys.Down:
                    btnY_Click(btnYP, EventArgs.Empty);
                    break;
                case Keys.F1:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F2:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F3:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F4:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F5:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F6:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F7:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
                case Keys.F8:
                    UpdateIncrement(MultiplierCtrls[e.KeyCode - Keys.F1], EventArgs.Empty);
                    break;
            }
        }

        private double feedRate = 200;

        private void updateFeed(object sender, EventArgs e)
        {
            feedRate = Convert.ToDouble((sender as Control).Text.Substring(1));
            foreach (var ctrl in FCtrls)
            {
                if (ctrl == sender)
                    ctrl.BackColor = Color.Red;
                else
                    ctrl.BackColor = Color.Lime;
            }

        }

        Control[] MoVeTypeControls{
            get { return new[] {btnG0, btnG1}; }
        }

        string moveType;
        private void updateMoveType(object sender, EventArgs e)
        {
            moveType = (sender as Control).Text;
            foreach (var ctrl in MoVeTypeControls)
            {
                if (ctrl == sender)
                    ctrl.BackColor = Color.Red;
                else
                    ctrl.BackColor = Color.Lime;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Red;
            Application.DoEvents();

            port.DtrEnable = true;
            port.RtsEnable = false;

            Thread.Sleep(3000);

            port.DtrEnable = false;
            port.RtsEnable = true;

            port.ReadLine();
            port.ReadLine();
            
            while (port.BytesToRead > 0)
            {
                port.ReadLine();
            }
            btnReset.BackColor = Color.Lime;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
