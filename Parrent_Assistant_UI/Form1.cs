using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Parrent_Assistant_UI
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = Homebutt.Height;
            pnlNav.Top = Homebutt.Top;
            pnlNav.Left = Homebutt.Left;
            Homebutt.BackColor = Color.FromArgb(215, 106, 223);

            Welcome.Text = "WELCOME TO SCREENTAKE";
            this.PnlFormLoader.Controls.Clear();
            Homephase homephase_vrb = new Homephase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homephase_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(homephase_vrb);
            homephase_vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Homebutt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Homebutt.Height;
            pnlNav.Top = Homebutt.Top;
            pnlNav.Left = Homebutt.Left;
            Homebutt.BackColor = Color.FromArgb(215, 106, 223);

            Welcome.Text = "WELCOME TO SCREENTAKE";
            this.PnlFormLoader.Controls.Clear();
            Homephase homephase_vrb = new Homephase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homephase_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(homephase_vrb);
            homephase_vrb.Show();
        }

        private void Settimerbutt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Settimerbutt.Height;
            pnlNav.Top = Settimerbutt.Top;          
            Settimerbutt.BackColor = Color.FromArgb(215, 106, 223);

            Welcome.Text = "SET TIMER";
            this.PnlFormLoader.Controls.Clear();
            Settimerphase SP_vrb = new Settimerphase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            SP_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(SP_vrb);
            SP_vrb.Show();
        }

        private void Contactusbutt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Contactusbutt.Height;
            pnlNav.Top = Contactusbutt.Top;
            Contactusbutt.BackColor = Color.FromArgb(215, 106, 223);

            Welcome.Text = "CONTACT";
            this.PnlFormLoader.Controls.Clear();
            ContactUsphase CU_vrb = new ContactUsphase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CU_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(CU_vrb);
            CU_vrb.Show();
        }

        private void Settingbutt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Settingbutt.Height;
            pnlNav.Top = Settingbutt.Top;
            Settingbutt.BackColor = Color.FromArgb(215, 106, 223);

            Welcome.Text = "SETTING";
            this.PnlFormLoader.Controls.Clear();
            Settingphase ST_vrb = new Settingphase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ST_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(ST_vrb);
            ST_vrb.Show();
        }

        private void Homebutt_Leave(object sender, EventArgs e)
        {
            Homebutt.BackColor = Color.FromArgb(124, 36, 172);
        }

        private void Settimerbutt_Leave(object sender, EventArgs e)
        {
            Settimerbutt.BackColor = Color.FromArgb(124, 36, 172);
        }

        private void Contactusbutt_Leave(object sender, EventArgs e)
        {
            Contactusbutt.BackColor = Color.FromArgb(124, 36, 172);
        }

        private void Settingbutt_Leave(object sender, EventArgs e)
        {
            Settingbutt.BackColor = Color.FromArgb(124, 36, 172);
        }

        private void ESCbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
