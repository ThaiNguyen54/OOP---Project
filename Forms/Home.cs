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
    public partial class Home : Form
    {
        private int ShutDownTime;
        public Home()
        {
            InitializeComponent();
            if(Properties.Settings.Default.TimerStart == false)
            {
                Properties.Settings.Default.ShutDownTime = Convert.ToInt32(Convert.ToInt32(Properties.Settings.Default.Second) +
                                                                           Convert.ToInt32(Properties.Settings.Default.Minute) * 60 +
                                                                           Convert.ToInt32(Properties.Settings.Default.Hour) * 60 * 60);
                Properties.Settings.Default.TimerStart = true;
                Properties.Settings.Default.Save();
            }
            ShutDownTime = Properties.Settings.Default.ShutDownTime;
           
            timer1.Start();
        }

        private void customedButton1_Click(object sender, EventArgs e)
        {
            if(customedTextBox_eixtPassword.Texts == Properties.Settings.Default.ExitPassword)
            {
                ShutDown.ShutDownCommand("-a");
                timer1.Stop();
            }
            else if(customedTextBox_eixtPassword.Texts != Properties.Settings.Default.ExitPassword)
            {
                MessageBox.Show("incorrect exit password");
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShutDownTime--;
            label_ShutDownTime.Text = Properties.Settings.Default.ShutDownTime.ToString() + " seconds";
 
        }
    }
}
