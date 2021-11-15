using FontAwesome.Sharp;
using Parent_Assistant.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeScreenLimit;

namespace Parent_Assistant
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentShowedForm;
        private bool isOpen;
        private bool isAble;
        private string ShutdownTime;
        private int shutdowntime;
        private int CaptureTime;
        private int SendMailTime;
        static string EmailAddress;
        static string imagePath = "Image_";
        static string imageExtension = ".png";
        public Form1()
        {
            InitializeComponent();

            //StartWithOperatingSystem.StartByCreatingShortcut("Parent Assistant.exe - Shortcut",
            //                                                @"C:\Users\thong\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup",
            //                                                "Parent Assistant.exe");
            //Properties.Settings.Default.IsShortcutCreated = true;
            //Properties.Settings.Default.Save();

            StartWithOperatingSystem.StartByRegistykey(Application.StartupPath, "Parent Assistant");



            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            isOpen = Properties.Settings.Default.IsOpened;
            CaptureTime = Properties.Settings.Default.CaptureTime;
            SendMailTime = Properties.Settings.Default.SendMailTime;
            EmailAddress = Properties.Settings.Default.EmailAddress;
            ShutdownTime = Convert.ToString(Convert.ToInt32(Properties.Settings.Default.Second) + 
                                            Convert.ToInt32(Properties.Settings.Default.Minute) * 60 + 
                                            Convert.ToInt32(Properties.Settings.Default.Hour) * 60 * 60);
            shutdowntime = Convert.ToInt32(ShutdownTime);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsOpened == true)
            {
                
                OpenSecondaryForm(new Home());
                ExecuteProccesses.Timer.TimerCapture(CaptureTime, imagePath, imageExtension);
                ExecuteProccesses.Timer.TimerSendMail(SendMailTime, imagePath, EmailAddress);
                if(ShutdownTime != "0" && ShutdownTime != string.Empty && ShutdownTime != " " )
                {
                    Thread thread = new Thread(() => ShutDown.ShutDownCommand("-s -t " + ShutdownTime));
                    thread.Start();
                }
               
                
            }
        }

        //Structs
        private struct RGBColrs
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }


        //Method
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();

                iconPictureBox_CurrentMenu.IconChar = currentBtn.IconChar;
                iconPictureBox_CurrentMenu.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(39, 142, 165);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenSecondaryForm(Form secondaryForm)
        {
            if(currentShowedForm != null)
            {
                currentShowedForm.Close();
            }
            currentShowedForm = secondaryForm;
            secondaryForm.TopLevel = false;
            secondaryForm.FormBorderStyle = FormBorderStyle.None;
            secondaryForm.Dock = DockStyle.Fill;
            panelDesktopForm.Controls.Add(secondaryForm);
            panelDesktopForm.Tag = secondaryForm;
            secondaryForm.BringToFront();
            secondaryForm.Show();
            label_CurrentMenuTitile.Text = secondaryForm.Text;
        }


        private void iconButton_Setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColrs.color1);
            OpenSecondaryForm(new SettingForm());
        }

        private void iconButton_ScreenTimeLimit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColrs.color2);
            OpenSecondaryForm(new ScreenTimeLimitForm());
        }

        private void iconButton_EmailAddress_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColrs.color3);
            OpenSecondaryForm(new EmailAddressForm());
        }

        private void iconButton_SetExitPassword_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColrs.color6);
            OpenSecondaryForm(new SetExitPasswordForm());
        }

        private void iconButton_ExitProgram_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColrs.color5);
            OpenSecondaryForm(new ExitProgramForm());
        }

        private void pictureBox_Home_Click(object sender, EventArgs e)
        {
            Reset();
            OpenSecondaryForm(new Home());

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox_CurrentMenu.IconChar = IconChar.Home;
            iconPictureBox_CurrentMenu.IconColor = Color.FromArgb(123, 17, 58);
            label_CurrentMenuTitile.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IsOpened = true;
            Properties.Settings.Default.TimerStart = false;
            //MessageBox.Show(Convert.ToString(Properties.Settings.Default.IsOpened));
            Properties.Settings.Default.Save();
        }

        private void iconButton_Closewindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter exit password and press exit button to close the program.");
            OpenSecondaryForm(new ExitProgramForm());
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000, "Be careful", "I am watching you", ToolTipIcon.Info);
                this.Hide();
            }
            else if(FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void iconButton_SystemTray_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000, "Be careful", "I am watching you", ToolTipIcon.Info);
            this.Hide();
        }
    }
}
