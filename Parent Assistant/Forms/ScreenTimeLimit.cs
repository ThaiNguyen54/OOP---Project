using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeScreenLimit;


namespace Parent_Assistant.Forms
{
    public partial class ScreenTimeLimitForm : Form
    {
        private string ShutDownTime;
        public ScreenTimeLimitForm()
        {
            InitializeComponent();
        }

        private void numericUpDown_Second_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown_Second.Value >= 60)
            {
                numericUpDown_Minutes.Value++;
                numericUpDown_Second.Value = 0;
            }
        }

        private void numericUpDown_Minutes_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown_Minutes.Value >= 60)
            {
                numericUpDown_Hour.Value++;
                numericUpDown_Minutes.Value = 0;
            }
        }

        private void customedButton_OK_Click(object sender, EventArgs e)
        {
            if(checkBox_SaveTimeScreen.Checked == true)
            {
                if(customedTextBox_exitpassword.Texts == Properties.Settings.Default.ExitPassword)
                {
                    Properties.Settings.Default.Hour = Convert.ToString(numericUpDown_Hour.Value);
                    Properties.Settings.Default.Minute = Convert.ToString(numericUpDown_Minutes.Value);
                    Properties.Settings.Default.Second = Convert.ToString(numericUpDown_Second.Value);
                    Properties.Settings.Default.TimerStart = false;
                    Properties.Settings.Default.Save();
                    ShutDownTime = Convert.ToString(Convert.ToInt32(Properties.Settings.Default.Second) +
                                            Convert.ToInt32(Properties.Settings.Default.Minute) * 60 +
                                            Convert.ToInt32(Properties.Settings.Default.Hour) * 60 * 60);
                    ShutDown.ShutDownCommand("-s -t " + ShutDownTime);
                    MessageBox.Show("Saved your setting.");
                }
                
                else if(customedTextBox_exitpassword.Texts != Properties.Settings.Default.ExitPassword)
                {
                    MessageBox.Show("Exit password is incorrect.");
                }
            }
            else if(checkBox_SaveTimeScreen.Checked == false)
            {
                MessageBox.Show("Save button was not clicked.");
            }
        }

        private void customedButton1_Click(object sender, EventArgs e)
        {
            ShutDown.ShutDownCommand("-a");
        }
    }
}
