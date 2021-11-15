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
    public partial class SettingForm : Form
    {
        private int CaptureTime;
        private int SendMailTime;
        static string EmailAddress;
        static string imagePath = "Image_";
        static string imageExtension = ".png";
        
        public SettingForm()
        {
            InitializeComponent();
            CaptureTime = 1000000;
            SendMailTime = 10000000;
            EmailAddress = Properties.Settings.Default.EmailAddress;
        }

        private void customedButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureTime = Convert.ToInt32(customedTextBox_CaptureTime.Texts);
                SendMailTime = Convert.ToInt32(customedTextBox_SendMailTime.Texts);
                if (checkBox_Save.Checked == true)
                {
                    if (EmailAddress == string.Empty || EmailAddress == " ")
                    {
                        MessageBox.Show("You haven't set your email address");
                    }
                    else if (EmailAddress != string.Empty && EmailAddress != " ")
                    {
                        if(customedTextBox_password.Texts == Properties.Settings.Default.ExitPassword)
                        {
                            Properties.Settings.Default.CaptureTime = CaptureTime;
                            Properties.Settings.Default.SendMailTime = SendMailTime;
                            Properties.Settings.Default.Save();
                            MessageBox.Show("Saved your setting. Program started. It will start automatically in the next time.");
                            //MessageBox.Show(EmailAddress);
                            ExecuteProccesses.Timer.TimerCapture(CaptureTime, imagePath, imageExtension);
                            ExecuteProccesses.Timer.TimerSendMail(SendMailTime, imagePath, EmailAddress);
                        }
                        else if(customedTextBox_password.Texts != Properties.Settings.Default.ExitPassword)
                        {
                            MessageBox.Show("Exit password is not correct.");
                        }
                        
                    }

                }
                else if(checkBox_Save.Checked == false)
                {
                    MessageBox.Show("Save button was not clicked.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
