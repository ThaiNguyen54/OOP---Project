using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Screentake
{
    public partial class MainProfile : Form
    {
        public MainProfile()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            new MainPhase().Show();
            this.Hide();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            new MainProfile().Show();
            this.Hide();
        }

        private void settingbutt_Click(object sender, EventArgs e)
        {
            new TimeSettingPhase().Show();
            this.Hide();
        }

        private void LogOutbutt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
