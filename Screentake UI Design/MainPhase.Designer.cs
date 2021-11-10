
namespace Screentake
{
    partial class MainPhase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPhase));
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.MainIcon = new System.Windows.Forms.PictureBox();
            this.TimeSetpics = new System.Windows.Forms.PictureBox();
            this.HOME = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.TakeAScreenShotbutt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSetpics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(387, 684);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackGround.TabIndex = 2;
            this.BackGround.TabStop = false;
            // 
            // MainIcon
            // 
            this.MainIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(78)))), ((int)(((byte)(177)))));
            this.MainIcon.Image = ((System.Drawing.Image)(resources.GetObject("MainIcon.Image")));
            this.MainIcon.Location = new System.Drawing.Point(12, 12);
            this.MainIcon.Name = "MainIcon";
            this.MainIcon.Size = new System.Drawing.Size(118, 105);
            this.MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainIcon.TabIndex = 14;
            this.MainIcon.TabStop = false;
            // 
            // TimeSetpics
            // 
            this.TimeSetpics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.TimeSetpics.Image = ((System.Drawing.Image)(resources.GetObject("TimeSetpics.Image")));
            this.TimeSetpics.Location = new System.Drawing.Point(309, 12);
            this.TimeSetpics.Name = "TimeSetpics";
            this.TimeSetpics.Size = new System.Drawing.Size(66, 65);
            this.TimeSetpics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TimeSetpics.TabIndex = 15;
            this.TimeSetpics.TabStop = false;
            this.TimeSetpics.Click += new System.EventHandler(this.TimeSetpics_Click);
            // 
            // HOME
            // 
            this.HOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.HOME.Image = ((System.Drawing.Image)(resources.GetObject("HOME.Image")));
            this.HOME.Location = new System.Drawing.Point(98, 603);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(87, 34);
            this.HOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HOME.TabIndex = 16;
            this.HOME.TabStop = false;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(209, 603);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(87, 34);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 17;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // TakeAScreenShotbutt
            // 
            this.TakeAScreenShotbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(169)))), ((int)(((byte)(239)))));
            this.TakeAScreenShotbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakeAScreenShotbutt.Location = new System.Drawing.Point(118, 229);
            this.TakeAScreenShotbutt.Name = "TakeAScreenShotbutt";
            this.TakeAScreenShotbutt.Size = new System.Drawing.Size(165, 64);
            this.TakeAScreenShotbutt.TabIndex = 18;
            this.TakeAScreenShotbutt.Text = "Take a screenshot";
            this.TakeAScreenShotbutt.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Emailbox);
            this.panel1.Location = new System.Drawing.Point(118, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 64);
            this.panel1.TabIndex = 19;
            // 
            // Emailbox
            // 
            this.Emailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.Emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emailbox.Location = new System.Drawing.Point(4, 23);
            this.Emailbox.Multiline = true;
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(158, 23);
            this.Emailbox.TabIndex = 0;
            this.Emailbox.Text = "Your Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(111)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(118, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your email to receive pics";
            // 
            // MainPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TakeAScreenShotbutt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.TimeSetpics);
            this.Controls.Add(this.MainIcon);
            this.Controls.Add(this.BackGround);
            this.Name = "MainPhase";
            this.Text = "MainPhase";
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSetpics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox MainIcon;
        private System.Windows.Forms.PictureBox TimeSetpics;
        private System.Windows.Forms.PictureBox HOME;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Button TakeAScreenShotbutt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.Label label1;
    }
}