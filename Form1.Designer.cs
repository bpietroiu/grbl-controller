namespace grblui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Label();
            this.btnYP = new System.Windows.Forms.Label();
            this.btnYM = new System.Windows.Forms.Label();
            this.btnXP = new System.Windows.Forms.Label();
            this.btnXM = new System.Windows.Forms.Label();
            this.btnMul005 = new System.Windows.Forms.Label();
            this.btnMul01 = new System.Windows.Forms.Label();
            this.label4btnMul05 = new System.Windows.Forms.Label();
            this.btnMul5 = new System.Windows.Forms.Label();
            this.btnMul1 = new System.Windows.Forms.Label();
            this.btnMul_5 = new System.Windows.Forms.Label();
            this.btnMul_1 = new System.Windows.Forms.Label();
            this.btnZM = new System.Windows.Forms.Label();
            this.btnZP = new System.Windows.Forms.Label();
            this.btnGoToZeroZ = new System.Windows.Forms.Label();
            this.btnGoToZeroY = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Label();
            this.btnGoToZeroX = new System.Windows.Forms.Label();
            this.btnZeroZ = new System.Windows.Forms.Label();
            this.btnZeroY = new System.Windows.Forms.Label();
            this.btnZeroX = new System.Windows.Forms.Label();
            this.btnZeroXY = new System.Windows.Forms.Label();
            this.btnZeroAll = new System.Windows.Forms.Label();
            this.btnMul001 = new System.Windows.Forms.Label();
            this.btnF50 = new System.Windows.Forms.Label();
            this.btnF100 = new System.Windows.Forms.Label();
            this.btnF150 = new System.Windows.Forms.Label();
            this.btnF200 = new System.Windows.Forms.Label();
            this.btnF250 = new System.Windows.Forms.Label();
            this.btnF300 = new System.Windows.Forms.Label();
            this.btnF400 = new System.Windows.Forms.Label();
            this.btnF500 = new System.Windows.Forms.Label();
            this.btnMul10 = new System.Windows.Forms.Label();
            this.btnMul50 = new System.Windows.Forms.Label();
            this.btnF10 = new System.Windows.Forms.Label();
            this.btnF5 = new System.Windows.Forms.Label();
            this.btnG0 = new System.Windows.Forms.Label();
            this.btnG1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Label();
            this.btnF1 = new System.Windows.Forms.Label();
            this.dspZ = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.dspY = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.dspX = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 50;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(858, 676);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(132, 58);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnect.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnYP
            // 
            this.btnYP.BackColor = System.Drawing.Color.Lime;
            this.btnYP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnYP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYP.Location = new System.Drawing.Point(317, 93);
            this.btnYP.Name = "btnYP";
            this.btnYP.Size = new System.Drawing.Size(64, 65);
            this.btnYP.TabIndex = 4;
            this.btnYP.Tag = "1";
            this.btnYP.Text = "Y+";
            this.btnYP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYP.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnYM
            // 
            this.btnYM.BackColor = System.Drawing.Color.Lime;
            this.btnYM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYM.Location = new System.Drawing.Point(175, 93);
            this.btnYM.Name = "btnYM";
            this.btnYM.Size = new System.Drawing.Size(64, 65);
            this.btnYM.TabIndex = 5;
            this.btnYM.Tag = "-1";
            this.btnYM.Text = "Y-";
            this.btnYM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYM.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnXP
            // 
            this.btnXP.BackColor = System.Drawing.Color.Lime;
            this.btnXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXP.Location = new System.Drawing.Point(317, 16);
            this.btnXP.Name = "btnXP";
            this.btnXP.Size = new System.Drawing.Size(64, 65);
            this.btnXP.TabIndex = 6;
            this.btnXP.Tag = "1";
            this.btnXP.Text = "X+";
            this.btnXP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXP.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnXM
            // 
            this.btnXM.BackColor = System.Drawing.Color.Lime;
            this.btnXM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnXM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXM.Location = new System.Drawing.Point(175, 16);
            this.btnXM.Name = "btnXM";
            this.btnXM.Size = new System.Drawing.Size(64, 65);
            this.btnXM.TabIndex = 7;
            this.btnXM.Tag = "-1";
            this.btnXM.Text = "X-";
            this.btnXM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXM.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnMul005
            // 
            this.btnMul005.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul005.BackColor = System.Drawing.Color.Lime;
            this.btnMul005.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul005.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul005.Location = new System.Drawing.Point(428, 44);
            this.btnMul005.Name = "btnMul005";
            this.btnMul005.Size = new System.Drawing.Size(56, 23);
            this.btnMul005.TabIndex = 9;
            this.btnMul005.Tag = "-1";
            this.btnMul005.Text = "0.005";
            this.btnMul005.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul005.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul01
            // 
            this.btnMul01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul01.BackColor = System.Drawing.Color.Lime;
            this.btnMul01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul01.Location = new System.Drawing.Point(428, 72);
            this.btnMul01.Name = "btnMul01";
            this.btnMul01.Size = new System.Drawing.Size(56, 23);
            this.btnMul01.TabIndex = 10;
            this.btnMul01.Tag = "-1";
            this.btnMul01.Text = "0.01";
            this.btnMul01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul01.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // label4btnMul05
            // 
            this.label4btnMul05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4btnMul05.BackColor = System.Drawing.Color.Lime;
            this.label4btnMul05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4btnMul05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4btnMul05.Location = new System.Drawing.Point(428, 100);
            this.label4btnMul05.Name = "label4btnMul05";
            this.label4btnMul05.Size = new System.Drawing.Size(56, 23);
            this.label4btnMul05.TabIndex = 11;
            this.label4btnMul05.Tag = "-1";
            this.label4btnMul05.Text = "0.05";
            this.label4btnMul05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4btnMul05.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul5
            // 
            this.btnMul5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul5.BackColor = System.Drawing.Color.Lime;
            this.btnMul5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul5.Location = new System.Drawing.Point(428, 212);
            this.btnMul5.Name = "btnMul5";
            this.btnMul5.Size = new System.Drawing.Size(56, 23);
            this.btnMul5.TabIndex = 15;
            this.btnMul5.Tag = "-1";
            this.btnMul5.Text = "5";
            this.btnMul5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul5.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul1
            // 
            this.btnMul1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul1.BackColor = System.Drawing.Color.Lime;
            this.btnMul1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul1.Location = new System.Drawing.Point(428, 184);
            this.btnMul1.Name = "btnMul1";
            this.btnMul1.Size = new System.Drawing.Size(56, 23);
            this.btnMul1.TabIndex = 14;
            this.btnMul1.Tag = "-1";
            this.btnMul1.Text = "1";
            this.btnMul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul1.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul_5
            // 
            this.btnMul_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul_5.BackColor = System.Drawing.Color.Lime;
            this.btnMul_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul_5.Location = new System.Drawing.Point(428, 156);
            this.btnMul_5.Name = "btnMul_5";
            this.btnMul_5.Size = new System.Drawing.Size(56, 23);
            this.btnMul_5.TabIndex = 13;
            this.btnMul_5.Tag = "-1";
            this.btnMul_5.Text = "0.5";
            this.btnMul_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul_5.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul_1
            // 
            this.btnMul_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul_1.BackColor = System.Drawing.Color.Lime;
            this.btnMul_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul_1.Location = new System.Drawing.Point(428, 128);
            this.btnMul_1.Name = "btnMul_1";
            this.btnMul_1.Size = new System.Drawing.Size(56, 23);
            this.btnMul_1.TabIndex = 12;
            this.btnMul_1.Tag = "-1";
            this.btnMul_1.Text = "0.1";
            this.btnMul_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul_1.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnZM
            // 
            this.btnZM.BackColor = System.Drawing.Color.Lime;
            this.btnZM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZM.Location = new System.Drawing.Point(175, 170);
            this.btnZM.Name = "btnZM";
            this.btnZM.Size = new System.Drawing.Size(64, 65);
            this.btnZM.TabIndex = 17;
            this.btnZM.Tag = "-1";
            this.btnZM.Text = "Z-";
            this.btnZM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZM.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnZP
            // 
            this.btnZP.BackColor = System.Drawing.Color.Lime;
            this.btnZP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZP.Location = new System.Drawing.Point(317, 170);
            this.btnZP.Name = "btnZP";
            this.btnZP.Size = new System.Drawing.Size(64, 65);
            this.btnZP.TabIndex = 16;
            this.btnZP.Tag = "1";
            this.btnZP.Text = "Z+";
            this.btnZP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZP.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnGoToZeroZ
            // 
            this.btnGoToZeroZ.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGoToZeroZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGoToZeroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToZeroZ.Location = new System.Drawing.Point(246, 170);
            this.btnGoToZeroZ.Name = "btnGoToZeroZ";
            this.btnGoToZeroZ.Size = new System.Drawing.Size(64, 65);
            this.btnGoToZeroZ.TabIndex = 18;
            this.btnGoToZeroZ.Tag = "-1";
            this.btnGoToZeroZ.Text = "0";
            this.btnGoToZeroZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoToZeroZ.Click += new System.EventHandler(this.btnGoToZeroZ_Click);
            // 
            // btnGoToZeroY
            // 
            this.btnGoToZeroY.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGoToZeroY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGoToZeroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToZeroY.Location = new System.Drawing.Point(246, 93);
            this.btnGoToZeroY.Name = "btnGoToZeroY";
            this.btnGoToZeroY.Size = new System.Drawing.Size(64, 65);
            this.btnGoToZeroY.TabIndex = 19;
            this.btnGoToZeroY.Tag = "-1";
            this.btnGoToZeroY.Text = "0";
            this.btnGoToZeroY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoToZeroY.Click += new System.EventHandler(this.btnGoToZeroY_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.Lime;
            this.btnGoTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(14, 170);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(116, 65);
            this.btnGoTo.TabIndex = 20;
            this.btnGoTo.Tag = "-1";
            this.btnGoTo.Text = "&GoTo";
            this.btnGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnGoToZeroX
            // 
            this.btnGoToZeroX.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGoToZeroX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGoToZeroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToZeroX.Location = new System.Drawing.Point(246, 16);
            this.btnGoToZeroX.Name = "btnGoToZeroX";
            this.btnGoToZeroX.Size = new System.Drawing.Size(64, 65);
            this.btnGoToZeroX.TabIndex = 19;
            this.btnGoToZeroX.Tag = "-1";
            this.btnGoToZeroX.Text = "0";
            this.btnGoToZeroX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoToZeroX.Click += new System.EventHandler(this.btnGoToZeroX_Click);
            // 
            // btnZeroZ
            // 
            this.btnZeroZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZeroZ.BackColor = System.Drawing.Color.Yellow;
            this.btnZeroZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZeroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroZ.Location = new System.Drawing.Point(1112, 171);
            this.btnZeroZ.Name = "btnZeroZ";
            this.btnZeroZ.Size = new System.Drawing.Size(85, 65);
            this.btnZeroZ.TabIndex = 18;
            this.btnZeroZ.Tag = "-1";
            this.btnZeroZ.Text = "Zero";
            this.btnZeroZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZeroZ.Click += new System.EventHandler(this.btnZeroZ_Click);
            // 
            // btnZeroY
            // 
            this.btnZeroY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZeroY.BackColor = System.Drawing.Color.Yellow;
            this.btnZeroY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZeroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroY.Location = new System.Drawing.Point(1112, 94);
            this.btnZeroY.Name = "btnZeroY";
            this.btnZeroY.Size = new System.Drawing.Size(85, 65);
            this.btnZeroY.TabIndex = 19;
            this.btnZeroY.Tag = "-1";
            this.btnZeroY.Text = "Zero";
            this.btnZeroY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZeroY.Click += new System.EventHandler(this.btnZeroY_Click);
            // 
            // btnZeroX
            // 
            this.btnZeroX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZeroX.BackColor = System.Drawing.Color.Yellow;
            this.btnZeroX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZeroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroX.Location = new System.Drawing.Point(1112, 17);
            this.btnZeroX.Name = "btnZeroX";
            this.btnZeroX.Size = new System.Drawing.Size(85, 65);
            this.btnZeroX.TabIndex = 19;
            this.btnZeroX.Tag = "-1";
            this.btnZeroX.Text = "Zero";
            this.btnZeroX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZeroX.Click += new System.EventHandler(this.btnZeroX_Click);
            // 
            // btnZeroXY
            // 
            this.btnZeroXY.BackColor = System.Drawing.Color.Lime;
            this.btnZeroXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZeroXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroXY.Location = new System.Drawing.Point(14, 16);
            this.btnZeroXY.Name = "btnZeroXY";
            this.btnZeroXY.Size = new System.Drawing.Size(116, 65);
            this.btnZeroXY.TabIndex = 21;
            this.btnZeroXY.Tag = "-1";
            this.btnZeroXY.Text = "Zero XY";
            this.btnZeroXY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZeroXY.Click += new System.EventHandler(this.btnZeroXY_Click);
            // 
            // btnZeroAll
            // 
            this.btnZeroAll.BackColor = System.Drawing.Color.Lime;
            this.btnZeroAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnZeroAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroAll.Location = new System.Drawing.Point(14, 93);
            this.btnZeroAll.Name = "btnZeroAll";
            this.btnZeroAll.Size = new System.Drawing.Size(116, 65);
            this.btnZeroAll.TabIndex = 21;
            this.btnZeroAll.Tag = "-1";
            this.btnZeroAll.Text = "Zero All";
            this.btnZeroAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZeroAll.Click += new System.EventHandler(this.btnZeroAll_Click);
            // 
            // btnMul001
            // 
            this.btnMul001.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul001.BackColor = System.Drawing.Color.Lime;
            this.btnMul001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul001.Location = new System.Drawing.Point(428, 16);
            this.btnMul001.Name = "btnMul001";
            this.btnMul001.Size = new System.Drawing.Size(56, 23);
            this.btnMul001.TabIndex = 8;
            this.btnMul001.Tag = "-1";
            this.btnMul001.Text = "0.001";
            this.btnMul001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul001.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnF50
            // 
            this.btnF50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF50.BackColor = System.Drawing.Color.Lime;
            this.btnF50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF50.Location = new System.Drawing.Point(511, 100);
            this.btnF50.Name = "btnF50";
            this.btnF50.Size = new System.Drawing.Size(56, 23);
            this.btnF50.TabIndex = 22;
            this.btnF50.Tag = "-1";
            this.btnF50.Text = "F50";
            this.btnF50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF50.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF100
            // 
            this.btnF100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF100.BackColor = System.Drawing.Color.Lime;
            this.btnF100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF100.Location = new System.Drawing.Point(511, 128);
            this.btnF100.Name = "btnF100";
            this.btnF100.Size = new System.Drawing.Size(56, 23);
            this.btnF100.TabIndex = 22;
            this.btnF100.Tag = "-1";
            this.btnF100.Text = "F100";
            this.btnF100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF100.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF150
            // 
            this.btnF150.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF150.BackColor = System.Drawing.Color.Lime;
            this.btnF150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF150.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF150.Location = new System.Drawing.Point(511, 156);
            this.btnF150.Name = "btnF150";
            this.btnF150.Size = new System.Drawing.Size(56, 23);
            this.btnF150.TabIndex = 22;
            this.btnF150.Tag = "-1";
            this.btnF150.Text = "F150";
            this.btnF150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF150.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF200
            // 
            this.btnF200.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF200.BackColor = System.Drawing.Color.Lime;
            this.btnF200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF200.Location = new System.Drawing.Point(511, 184);
            this.btnF200.Name = "btnF200";
            this.btnF200.Size = new System.Drawing.Size(56, 23);
            this.btnF200.TabIndex = 22;
            this.btnF200.Tag = "-1";
            this.btnF200.Text = "F200";
            this.btnF200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF200.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF250
            // 
            this.btnF250.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF250.BackColor = System.Drawing.Color.Lime;
            this.btnF250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF250.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF250.Location = new System.Drawing.Point(511, 212);
            this.btnF250.Name = "btnF250";
            this.btnF250.Size = new System.Drawing.Size(56, 23);
            this.btnF250.TabIndex = 22;
            this.btnF250.Tag = "-1";
            this.btnF250.Text = "F250";
            this.btnF250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF250.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF300
            // 
            this.btnF300.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF300.BackColor = System.Drawing.Color.Lime;
            this.btnF300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF300.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF300.Location = new System.Drawing.Point(511, 240);
            this.btnF300.Name = "btnF300";
            this.btnF300.Size = new System.Drawing.Size(56, 23);
            this.btnF300.TabIndex = 22;
            this.btnF300.Tag = "-1";
            this.btnF300.Text = "F300";
            this.btnF300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF300.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF400
            // 
            this.btnF400.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF400.BackColor = System.Drawing.Color.Lime;
            this.btnF400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF400.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF400.Location = new System.Drawing.Point(511, 268);
            this.btnF400.Name = "btnF400";
            this.btnF400.Size = new System.Drawing.Size(56, 23);
            this.btnF400.TabIndex = 22;
            this.btnF400.Tag = "-1";
            this.btnF400.Text = "F400";
            this.btnF400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF400.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF500
            // 
            this.btnF500.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF500.BackColor = System.Drawing.Color.Lime;
            this.btnF500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF500.Location = new System.Drawing.Point(511, 296);
            this.btnF500.Name = "btnF500";
            this.btnF500.Size = new System.Drawing.Size(56, 23);
            this.btnF500.TabIndex = 22;
            this.btnF500.Tag = "-1";
            this.btnF500.Text = "F500";
            this.btnF500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF500.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnMul10
            // 
            this.btnMul10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul10.BackColor = System.Drawing.Color.Lime;
            this.btnMul10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul10.Location = new System.Drawing.Point(428, 241);
            this.btnMul10.Name = "btnMul10";
            this.btnMul10.Size = new System.Drawing.Size(56, 23);
            this.btnMul10.TabIndex = 23;
            this.btnMul10.Tag = "-1";
            this.btnMul10.Text = "10";
            this.btnMul10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul10.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnMul50
            // 
            this.btnMul50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMul50.BackColor = System.Drawing.Color.Lime;
            this.btnMul50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMul50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul50.Location = new System.Drawing.Point(428, 270);
            this.btnMul50.Name = "btnMul50";
            this.btnMul50.Size = new System.Drawing.Size(56, 23);
            this.btnMul50.TabIndex = 23;
            this.btnMul50.Tag = "-1";
            this.btnMul50.Text = "50";
            this.btnMul50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMul50.Click += new System.EventHandler(this.UpdateIncrement);
            // 
            // btnF10
            // 
            this.btnF10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF10.BackColor = System.Drawing.Color.Lime;
            this.btnF10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF10.Location = new System.Drawing.Point(511, 72);
            this.btnF10.Name = "btnF10";
            this.btnF10.Size = new System.Drawing.Size(56, 23);
            this.btnF10.TabIndex = 22;
            this.btnF10.Tag = "-1";
            this.btnF10.Text = "F10";
            this.btnF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF10.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnF5
            // 
            this.btnF5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF5.BackColor = System.Drawing.Color.Lime;
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF5.Location = new System.Drawing.Point(511, 44);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(56, 23);
            this.btnF5.TabIndex = 22;
            this.btnF5.Tag = "-1";
            this.btnF5.Text = "F5";
            this.btnF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF5.Click += new System.EventHandler(this.updateFeed);
            // 
            // btnG0
            // 
            this.btnG0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnG0.BackColor = System.Drawing.Color.Lime;
            this.btnG0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG0.Location = new System.Drawing.Point(595, 16);
            this.btnG0.Name = "btnG0";
            this.btnG0.Size = new System.Drawing.Size(56, 23);
            this.btnG0.TabIndex = 25;
            this.btnG0.Tag = "G0";
            this.btnG0.Text = "G0";
            this.btnG0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnG0.Click += new System.EventHandler(this.updateMoveType);
            // 
            // btnG1
            // 
            this.btnG1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnG1.BackColor = System.Drawing.Color.Lime;
            this.btnG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG1.Location = new System.Drawing.Point(595, 44);
            this.btnG1.Name = "btnG1";
            this.btnG1.Size = new System.Drawing.Size(56, 23);
            this.btnG1.TabIndex = 24;
            this.btnG1.Tag = "G1";
            this.btnG1.Text = "G1";
            this.btnG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnG1.Click += new System.EventHandler(this.updateMoveType);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1051, 676);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 58);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnF1
            // 
            this.btnF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF1.BackColor = System.Drawing.Color.Lime;
            this.btnF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1.Location = new System.Drawing.Point(511, 16);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(56, 23);
            this.btnF1.TabIndex = 22;
            this.btnF1.Tag = "-1";
            this.btnF1.Text = "F1";
            this.btnF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnF1.Click += new System.EventHandler(this.updateFeed);
            // 
            // dspZ
            // 
            this.dspZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dspZ.ArrayCount = 8;
            this.dspZ.ColorBackground = System.Drawing.SystemColors.Control;
            this.dspZ.ColorDark = System.Drawing.Color.White;
            this.dspZ.ColorLight = System.Drawing.Color.Red;
            this.dspZ.DecimalShow = true;
            this.dspZ.ElementPadding = new System.Windows.Forms.Padding(4);
            this.dspZ.ElementWidth = 10;
            this.dspZ.ItalicFactor = 0F;
            this.dspZ.Location = new System.Drawing.Point(675, 167);
            this.dspZ.Name = "dspZ";
            this.dspZ.Size = new System.Drawing.Size(419, 71);
            this.dspZ.TabIndex = 2;
            this.dspZ.TabStop = false;
            this.dspZ.Value = "0";
            // 
            // dspY
            // 
            this.dspY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dspY.ArrayCount = 8;
            this.dspY.ColorBackground = System.Drawing.SystemColors.Control;
            this.dspY.ColorDark = System.Drawing.Color.White;
            this.dspY.ColorLight = System.Drawing.Color.Red;
            this.dspY.DecimalShow = true;
            this.dspY.ElementPadding = new System.Windows.Forms.Padding(4);
            this.dspY.ElementWidth = 10;
            this.dspY.ItalicFactor = 0F;
            this.dspY.Location = new System.Drawing.Point(675, 90);
            this.dspY.Name = "dspY";
            this.dspY.Size = new System.Drawing.Size(419, 71);
            this.dspY.TabIndex = 1;
            this.dspY.TabStop = false;
            this.dspY.Value = "0";
            this.dspY.Load += new System.EventHandler(this.sevenSegmentArray2_Load);
            // 
            // dspX
            // 
            this.dspX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dspX.ArrayCount = 8;
            this.dspX.ColorBackground = System.Drawing.SystemColors.Control;
            this.dspX.ColorDark = System.Drawing.Color.White;
            this.dspX.ColorLight = System.Drawing.Color.Red;
            this.dspX.DecimalShow = true;
            this.dspX.ElementPadding = new System.Windows.Forms.Padding(4);
            this.dspX.ElementWidth = 10;
            this.dspX.ItalicFactor = 0F;
            this.dspX.Location = new System.Drawing.Point(675, 13);
            this.dspX.Name = "dspX";
            this.dspX.Size = new System.Drawing.Size(419, 71);
            this.dspX.TabIndex = 0;
            this.dspX.TabStop = false;
            this.dspX.Value = "0";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Lime;
            this.btnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(14, 669);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 65);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Tag = "-1";
            this.btnLoad.Text = "&Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 756);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnG0);
            this.Controls.Add(this.btnG1);
            this.Controls.Add(this.btnMul50);
            this.Controls.Add(this.btnMul10);
            this.Controls.Add(this.btnF500);
            this.Controls.Add(this.btnF400);
            this.Controls.Add(this.btnF300);
            this.Controls.Add(this.btnF250);
            this.Controls.Add(this.btnF200);
            this.Controls.Add(this.btnF150);
            this.Controls.Add(this.btnF100);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.btnF10);
            this.Controls.Add(this.btnF50);
            this.Controls.Add(this.btnZeroAll);
            this.Controls.Add(this.btnZeroXY);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnZeroX);
            this.Controls.Add(this.btnZeroY);
            this.Controls.Add(this.btnGoToZeroX);
            this.Controls.Add(this.btnZeroZ);
            this.Controls.Add(this.btnGoToZeroY);
            this.Controls.Add(this.btnGoToZeroZ);
            this.Controls.Add(this.btnZM);
            this.Controls.Add(this.btnZP);
            this.Controls.Add(this.btnMul5);
            this.Controls.Add(this.btnMul1);
            this.Controls.Add(this.btnMul_5);
            this.Controls.Add(this.btnMul_1);
            this.Controls.Add(this.label4btnMul05);
            this.Controls.Add(this.btnMul01);
            this.Controls.Add(this.btnMul005);
            this.Controls.Add(this.btnMul001);
            this.Controls.Add(this.btnXM);
            this.Controls.Add(this.btnXP);
            this.Controls.Add(this.btnYM);
            this.Controls.Add(this.btnYP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dspZ);
            this.Controls.Add(this.dspY);
            this.Controls.Add(this.dspX);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "grbl cnc controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray dspX;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Timer statusTimer;
        private DmitryBrant.CustomControls.SevenSegmentArray dspY;
        private DmitryBrant.CustomControls.SevenSegmentArray dspZ;
        private System.Windows.Forms.Label btnConnect;
        private System.Windows.Forms.Label btnYP;
        private System.Windows.Forms.Label btnYM;
        private System.Windows.Forms.Label btnXP;
        private System.Windows.Forms.Label btnXM;
        private System.Windows.Forms.Label btnMul005;
        private System.Windows.Forms.Label btnMul01;
        private System.Windows.Forms.Label label4btnMul05;
        private System.Windows.Forms.Label btnMul5;
        private System.Windows.Forms.Label btnMul1;
        private System.Windows.Forms.Label btnMul_5;
        private System.Windows.Forms.Label btnMul_1;
        private System.Windows.Forms.Label btnZM;
        private System.Windows.Forms.Label btnZP;
        private System.Windows.Forms.Label btnGoToZeroZ;
        private System.Windows.Forms.Label btnGoToZeroY;
        private System.Windows.Forms.Label btnGoTo;
        private System.Windows.Forms.Label btnGoToZeroX;
        private System.Windows.Forms.Label btnZeroZ;
        private System.Windows.Forms.Label btnZeroY;
        private System.Windows.Forms.Label btnZeroX;
        private System.Windows.Forms.Label btnZeroXY;
        private System.Windows.Forms.Label btnZeroAll;
        private System.Windows.Forms.Label btnMul001;
        private System.Windows.Forms.Label btnF50;
        private System.Windows.Forms.Label btnF100;
        private System.Windows.Forms.Label btnF150;
        private System.Windows.Forms.Label btnF200;
        private System.Windows.Forms.Label btnF250;
        private System.Windows.Forms.Label btnF300;
        private System.Windows.Forms.Label btnF400;
        private System.Windows.Forms.Label btnF500;
        private System.Windows.Forms.Label btnMul10;
        private System.Windows.Forms.Label btnMul50;
        private System.Windows.Forms.Label btnF10;
        private System.Windows.Forms.Label btnF5;
        private System.Windows.Forms.Label btnG0;
        private System.Windows.Forms.Label btnG1;
        private System.Windows.Forms.Label btnReset;
        private System.Windows.Forms.Label btnF1;
        private System.Windows.Forms.Label btnLoad;
    }
}

