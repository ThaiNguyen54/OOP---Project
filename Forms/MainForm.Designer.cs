
namespace Parent_Assistant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton_ExitProgram = new FontAwesome.Sharp.IconButton();
            this.iconButton_SetExitPassword = new FontAwesome.Sharp.IconButton();
            this.iconButton_EmailAddress = new FontAwesome.Sharp.IconButton();
            this.iconButton_ScreenTimeLimit = new FontAwesome.Sharp.IconButton();
            this.iconButton_Setting = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButton_SystemTray = new FontAwesome.Sharp.IconButton();
            this.iconButton_Closewindow = new FontAwesome.Sharp.IconButton();
            this.label_CurrentMenuTitile = new System.Windows.Forms.Label();
            this.iconPictureBox_CurrentMenu = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktopForm = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_CurrentMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.panelMenu.Controls.Add(this.iconButton_ExitProgram);
            this.panelMenu.Controls.Add(this.iconButton_SetExitPassword);
            this.panelMenu.Controls.Add(this.iconButton_EmailAddress);
            this.panelMenu.Controls.Add(this.iconButton_ScreenTimeLimit);
            this.panelMenu.Controls.Add(this.iconButton_Setting);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton_ExitProgram
            // 
            this.iconButton_ExitProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_ExitProgram.FlatAppearance.BorderSize = 0;
            this.iconButton_ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ExitProgram.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_ExitProgram.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.iconButton_ExitProgram.IconColor = System.Drawing.Color.Black;
            this.iconButton_ExitProgram.IconSize = 35;
            this.iconButton_ExitProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_ExitProgram.Location = new System.Drawing.Point(0, 380);
            this.iconButton_ExitProgram.Name = "iconButton_ExitProgram";
            this.iconButton_ExitProgram.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_ExitProgram.Rotation = 0D;
            this.iconButton_ExitProgram.Size = new System.Drawing.Size(220, 60);
            this.iconButton_ExitProgram.TabIndex = 6;
            this.iconButton_ExitProgram.Text = "Exit Program";
            this.iconButton_ExitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_ExitProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_ExitProgram.UseVisualStyleBackColor = true;
            this.iconButton_ExitProgram.Click += new System.EventHandler(this.iconButton_ExitProgram_Click);
            // 
            // iconButton_SetExitPassword
            // 
            this.iconButton_SetExitPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_SetExitPassword.FlatAppearance.BorderSize = 0;
            this.iconButton_SetExitPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_SetExitPassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_SetExitPassword.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.iconButton_SetExitPassword.IconColor = System.Drawing.Color.Black;
            this.iconButton_SetExitPassword.IconSize = 35;
            this.iconButton_SetExitPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_SetExitPassword.Location = new System.Drawing.Point(0, 320);
            this.iconButton_SetExitPassword.Name = "iconButton_SetExitPassword";
            this.iconButton_SetExitPassword.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_SetExitPassword.Rotation = 0D;
            this.iconButton_SetExitPassword.Size = new System.Drawing.Size(220, 60);
            this.iconButton_SetExitPassword.TabIndex = 5;
            this.iconButton_SetExitPassword.Text = "Set Exit Password";
            this.iconButton_SetExitPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_SetExitPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_SetExitPassword.UseVisualStyleBackColor = true;
            this.iconButton_SetExitPassword.Click += new System.EventHandler(this.iconButton_SetExitPassword_Click);
            // 
            // iconButton_EmailAddress
            // 
            this.iconButton_EmailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_EmailAddress.FlatAppearance.BorderSize = 0;
            this.iconButton_EmailAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_EmailAddress.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_EmailAddress.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton_EmailAddress.IconColor = System.Drawing.Color.Black;
            this.iconButton_EmailAddress.IconSize = 35;
            this.iconButton_EmailAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_EmailAddress.Location = new System.Drawing.Point(0, 260);
            this.iconButton_EmailAddress.Name = "iconButton_EmailAddress";
            this.iconButton_EmailAddress.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_EmailAddress.Rotation = 0D;
            this.iconButton_EmailAddress.Size = new System.Drawing.Size(220, 60);
            this.iconButton_EmailAddress.TabIndex = 4;
            this.iconButton_EmailAddress.Text = " Email Address";
            this.iconButton_EmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_EmailAddress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_EmailAddress.UseVisualStyleBackColor = true;
            this.iconButton_EmailAddress.Click += new System.EventHandler(this.iconButton_EmailAddress_Click);
            // 
            // iconButton_ScreenTimeLimit
            // 
            this.iconButton_ScreenTimeLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_ScreenTimeLimit.FlatAppearance.BorderSize = 0;
            this.iconButton_ScreenTimeLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ScreenTimeLimit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_ScreenTimeLimit.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButton_ScreenTimeLimit.IconColor = System.Drawing.Color.Black;
            this.iconButton_ScreenTimeLimit.IconSize = 35;
            this.iconButton_ScreenTimeLimit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_ScreenTimeLimit.Location = new System.Drawing.Point(0, 200);
            this.iconButton_ScreenTimeLimit.Name = "iconButton_ScreenTimeLimit";
            this.iconButton_ScreenTimeLimit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_ScreenTimeLimit.Rotation = 0D;
            this.iconButton_ScreenTimeLimit.Size = new System.Drawing.Size(220, 60);
            this.iconButton_ScreenTimeLimit.TabIndex = 3;
            this.iconButton_ScreenTimeLimit.Text = "Screen Time Limit";
            this.iconButton_ScreenTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_ScreenTimeLimit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_ScreenTimeLimit.UseVisualStyleBackColor = true;
            this.iconButton_ScreenTimeLimit.Click += new System.EventHandler(this.iconButton_ScreenTimeLimit_Click);
            // 
            // iconButton_Setting
            // 
            this.iconButton_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Setting.FlatAppearance.BorderSize = 0;
            this.iconButton_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Setting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Setting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton_Setting.IconColor = System.Drawing.Color.Black;
            this.iconButton_Setting.IconSize = 35;
            this.iconButton_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Setting.Location = new System.Drawing.Point(0, 140);
            this.iconButton_Setting.Name = "iconButton_Setting";
            this.iconButton_Setting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_Setting.Rotation = 0D;
            this.iconButton_Setting.Size = new System.Drawing.Size(220, 60);
            this.iconButton_Setting.TabIndex = 2;
            this.iconButton_Setting.Text = "Setting";
            this.iconButton_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Setting.UseVisualStyleBackColor = true;
            this.iconButton_Setting.Click += new System.EventHandler(this.iconButton_Setting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_Home
            // 
            this.pictureBox_Home.Image = global::Parent_Assistant.Properties.Resources.Parents_Assistant_Logo;
            this.pictureBox_Home.Location = new System.Drawing.Point(13, 12);
            this.pictureBox_Home.Name = "pictureBox_Home";
            this.pictureBox_Home.Size = new System.Drawing.Size(184, 122);
            this.pictureBox_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Home.TabIndex = 0;
            this.pictureBox_Home.TabStop = false;
            this.pictureBox_Home.Click += new System.EventHandler(this.pictureBox_Home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.panelTitleBar.Controls.Add(this.iconButton_SystemTray);
            this.panelTitleBar.Controls.Add(this.iconButton_Closewindow);
            this.panelTitleBar.Controls.Add(this.label_CurrentMenuTitile);
            this.panelTitleBar.Controls.Add(this.iconPictureBox_CurrentMenu);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(764, 55);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButton_SystemTray
            // 
            this.iconButton_SystemTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.iconButton_SystemTray.FlatAppearance.BorderSize = 0;
            this.iconButton_SystemTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_SystemTray.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_SystemTray.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton_SystemTray.IconColor = System.Drawing.Color.Black;
            this.iconButton_SystemTray.IconSize = 30;
            this.iconButton_SystemTray.Location = new System.Drawing.Point(668, -2);
            this.iconButton_SystemTray.Name = "iconButton_SystemTray";
            this.iconButton_SystemTray.Rotation = 0D;
            this.iconButton_SystemTray.Size = new System.Drawing.Size(45, 36);
            this.iconButton_SystemTray.TabIndex = 2;
            this.iconButton_SystemTray.UseVisualStyleBackColor = false;
            this.iconButton_SystemTray.Click += new System.EventHandler(this.iconButton_SystemTray_Click_1);
            // 
            // iconButton_Closewindow
            // 
            this.iconButton_Closewindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.iconButton_Closewindow.FlatAppearance.BorderSize = 0;
            this.iconButton_Closewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Closewindow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Closewindow.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton_Closewindow.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton_Closewindow.IconSize = 30;
            this.iconButton_Closewindow.Location = new System.Drawing.Point(719, 3);
            this.iconButton_Closewindow.Name = "iconButton_Closewindow";
            this.iconButton_Closewindow.Rotation = 0D;
            this.iconButton_Closewindow.Size = new System.Drawing.Size(45, 36);
            this.iconButton_Closewindow.TabIndex = 0;
            this.iconButton_Closewindow.UseVisualStyleBackColor = false;
            this.iconButton_Closewindow.Click += new System.EventHandler(this.iconButton_Closewindow_Click);
            // 
            // label_CurrentMenuTitile
            // 
            this.label_CurrentMenuTitile.AutoSize = true;
            this.label_CurrentMenuTitile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_CurrentMenuTitile.Location = new System.Drawing.Point(45, 21);
            this.label_CurrentMenuTitile.Name = "label_CurrentMenuTitile";
            this.label_CurrentMenuTitile.Size = new System.Drawing.Size(35, 13);
            this.label_CurrentMenuTitile.TabIndex = 1;
            this.label_CurrentMenuTitile.Text = "Home";
            // 
            // iconPictureBox_CurrentMenu
            // 
            this.iconPictureBox_CurrentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.iconPictureBox_CurrentMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(17)))), ((int)(((byte)(58)))));
            this.iconPictureBox_CurrentMenu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox_CurrentMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(17)))), ((int)(((byte)(58)))));
            this.iconPictureBox_CurrentMenu.Location = new System.Drawing.Point(7, 12);
            this.iconPictureBox_CurrentMenu.Name = "iconPictureBox_CurrentMenu";
            this.iconPictureBox_CurrentMenu.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_CurrentMenu.TabIndex = 0;
            this.iconPictureBox_CurrentMenu.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 55);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(764, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktopForm
            // 
            this.panelDesktopForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panelDesktopForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopForm.Location = new System.Drawing.Point(220, 65);
            this.panelDesktopForm.Name = "panelDesktopForm";
            this.panelDesktopForm.Size = new System.Drawing.Size(764, 488);
            this.panelDesktopForm.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Parents Assistant";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 553);
            this.Controls.Add(this.panelDesktopForm);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parents Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_CurrentMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton_Setting;
        private FontAwesome.Sharp.IconButton iconButton_ExitProgram;
        private FontAwesome.Sharp.IconButton iconButton_SetExitPassword;
        private FontAwesome.Sharp.IconButton iconButton_EmailAddress;
        private FontAwesome.Sharp.IconButton iconButton_ScreenTimeLimit;
        private System.Windows.Forms.PictureBox pictureBox_Home;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_CurrentMenu;
        private System.Windows.Forms.Label label_CurrentMenuTitile;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktopForm;
        private FontAwesome.Sharp.IconButton iconButton_Closewindow;
        private FontAwesome.Sharp.IconButton iconButton_SystemTray;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

