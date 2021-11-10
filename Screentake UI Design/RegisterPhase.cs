using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Screentake
{
    public partial class RegisterPhase : Form
    {
        public RegisterPhase()
        {
            InitializeComponent();
        }

        private void signinlabel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void ESCbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
