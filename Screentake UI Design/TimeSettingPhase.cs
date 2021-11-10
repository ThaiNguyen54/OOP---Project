using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Screentake
{
    public partial class TimeSettingPhase : Form
    {
        public TimeSettingPhase()
        {
            InitializeComponent();
        }

        private void BACKbutt_Click(object sender, EventArgs e)
        {
            new MainPhase().Show();
            this.Hide();
        }
    }
}
