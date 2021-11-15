using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parent_Assistant.Forms
{
    public partial class ExitProgramForm : Form
    {
        private string exitPassword;
        public ExitProgramForm()
        {
            InitializeComponent();
        }

        public string ExitPassword { get => exitPassword; set => exitPassword = value; }

        private void customedButton_OK_Click(object sender, EventArgs e)
        {
            if(customedTextBox_ExitPassword.Texts == Properties.Settings.Default.ExitPassword)
            {
                Properties.Settings.Default.IsOpened = true;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
            else if(customedTextBox_ExitPassword.Texts != Properties.Settings.Default.ExitPassword)
            {
                MessageBox.Show("Incorrect exit password.");
            }
        }
    }
}
