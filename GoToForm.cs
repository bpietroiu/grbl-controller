using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace grblui
{
    public partial class GoToForm : Form
    {
        public GoToForm()
        {
            InitializeComponent();
        }

        public decimal X
        {
            get { return xUpDown.Value; }
            set { xUpDown.Value = value; }
        }

        public decimal Y
        {
            get { return yUpDown.Value; }
            set { yUpDown.Value = value; }
        }
        public decimal Z
        {
            get { return zUpDown.Value; }
            set { zUpDown.Value = value; }
        }

        private void GoToForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                DialogResult = DialogResult.OK;
        }

    }
}
