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
    public partial class SetExitPasswordForm : Form
    {
        public SetExitPasswordForm()
        {
            InitializeComponent();
        }

        private void customedButton_OK_Click(object sender, EventArgs e)
        {
            if(checkBox_Save.Checked == true)
            {
                if(customedTextBox_OldPassword.Texts == Properties.Settings.Default.ExitPassword)
                {
                    Properties.Settings.Default.ExitPassword = customedTextBox_NewPassword.Texts;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Saved your new exit password");
                }
                else if(customedTextBox_OldPassword.Texts != Properties.Settings.Default.ExitPassword)
                {
                    MessageBox.Show("Old password is incorrect.");
                }
            }
            else if(checkBox_Save.Checked == false)
            {
                MessageBox.Show("Save button was not clicked.");
            }
        }
    }
}
