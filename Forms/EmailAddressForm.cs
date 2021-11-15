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
    public partial class EmailAddressForm : Form
    {
        public EmailAddressForm()
        {
            InitializeComponent();
        }

        private void customedButton_OK_Click(object sender, EventArgs e)
        {
            if(checkBox_SaveEmail.Checked == true)
            {
                if(customedTextBox_exitpassword.Texts == Properties.Settings.Default.ExitPassword)
                {
                    Properties.Settings.Default.EmailAddress = customedTextBox_EamilAddress.Texts;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Saved your email");
                }
                else if (customedTextBox_exitpassword.Texts != Properties.Settings.Default.ExitPassword)
                {
                    MessageBox.Show("Exit password is incorrect.");
                }
                
            }
            else if(checkBox_SaveEmail.Checked == false)
            {
                MessageBox.Show("Save button was not clicked");
            }
        }
    }
}
