
namespace Screentake
{
    partial class MainProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProfile));
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainIcon = new System.Windows.Forms.PictureBox();
            this.Emailbutt = new System.Windows.Forms.Button();
            this.Changepassbutt = new System.Windows.Forms.Button();
            this.settingbutt = new System.Windows.Forms.Button();
            this.LogOutbutt = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(102)))), ((int)(((byte)(227)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainIcon
            // 
            this.MainIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(146)))), ((int)(((byte)(218)))));
            this.MainIcon.Image = ((System.Drawing.Image)(resources.GetObject("MainIcon.Image")));
            this.MainIcon.Location = new System.Drawing.Point(257, 12);
            this.MainIcon.Name = "MainIcon";
            this.MainIcon.Size = new System.Drawing.Size(118, 105);
            this.MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainIcon.TabIndex = 15;
            this.MainIcon.TabStop = false;
            // 
            // Emailbutt
            // 
            this.Emailbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.Emailbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emailbutt.Location = new System.Drawing.Point(81, 329);
            this.Emailbutt.Name = "Emailbutt";
            this.Emailbutt.Size = new System.Drawing.Size(237, 41);
            this.Emailbutt.TabIndex = 25;
            this.Emailbutt.Text = "Email";
            this.Emailbutt.UseVisualStyleBackColor = false;
            // 
            // Changepassbutt
            // 
            this.Changepassbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.Changepassbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Changepassbutt.Location = new System.Drawing.Point(81, 393);
            this.Changepassbutt.Name = "Changepassbutt";
            this.Changepassbutt.Size = new System.Drawing.Size(237, 41);
            this.Changepassbutt.TabIndex = 26;
            this.Changepassbutt.Text = "Change Password";
            this.Changepassbutt.UseVisualStyleBackColor = false;
            // 
            // settingbutt
            // 
            this.settingbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingbutt.Location = new System.Drawing.Point(81, 455);
            this.settingbutt.Name = "settingbutt";
            this.settingbutt.Size = new System.Drawing.Size(237, 41);
            this.settingbutt.TabIndex = 27;
            this.settingbutt.Text = "Setting";
            this.settingbutt.UseVisualStyleBackColor = false;
            this.settingbutt.Click += new System.EventHandler(this.settingbutt_Click);
            // 
            // LogOutbutt
            // 
            this.LogOutbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.LogOutbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutbutt.Location = new System.Drawing.Point(81, 518);
            this.LogOutbutt.Name = "LogOutbutt";
            this.LogOutbutt.Size = new System.Drawing.Size(237, 41);
            this.LogOutbutt.TabIndex = 28;
            this.LogOutbutt.Text = "LOGOUT";
            this.LogOutbutt.UseVisualStyleBackColor = false;
            this.LogOutbutt.Click += new System.EventHandler(this.LogOutbutt_Click);
            // 
            // HOME
            // 
            this.HOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.HOME.Image = ((System.Drawing.Image)(resources.GetObject("HOME.Image")));
            this.HOME.Location = new System.Drawing.Point(95, 609);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(87, 34);
            this.HOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HOME.TabIndex = 29;
            this.HOME.TabStop = false;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(205, 609);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(87, 34);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 30;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thanh123";
            // 
            // MainProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.LogOutbutt);
            this.Controls.Add(this.settingbutt);
            this.Controls.Add(this.Changepassbutt);
            this.Controls.Add(this.Emailbutt);
            this.Controls.Add(this.MainIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackGround);
            this.Name = "MainProfile";
            this.Text = "MainProfile";
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MainIcon;
        private System.Windows.Forms.Button Emailbutt;
        private System.Windows.Forms.Button Changepassbutt;
        private System.Windows.Forms.Button settingbutt;
        private System.Windows.Forms.Button LogOutbutt;
        private System.Windows.Forms.PictureBox HOME;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Label label1;
    }
}