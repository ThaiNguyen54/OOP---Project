using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screentake
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogInbutt_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Thanh123" && PassTextbox.Text == "1234567")
            {
                new MainPhase().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password is incorrect, try again");
                UsernameTextbox.Clear();
                PassTextbox.Clear();
                UsernameTextbox.Focus();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            new RegisterPhase().Show();
            this.Hide();
        }

        private void ESCbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
