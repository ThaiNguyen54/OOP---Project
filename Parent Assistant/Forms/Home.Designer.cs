
namespace Parent_Assistant.Forms
{
    partial class Home
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
            this.panelDesktopForm = new System.Windows.Forms.Panel();
            this.label_ShutDownTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customedTextBox_eixtPassword = new CoreUI.CustomedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customedButton1 = new CoreUI.CustomedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktopForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopForm
            // 
            this.panelDesktopForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panelDesktopForm.Controls.Add(this.label_ShutDownTime);
            this.panelDesktopForm.Controls.Add(this.label2);
            this.panelDesktopForm.Controls.Add(this.customedTextBox_eixtPassword);
            this.panelDesktopForm.Controls.Add(this.label1);
            this.panelDesktopForm.Controls.Add(this.customedButton1);
            this.panelDesktopForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopForm.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopForm.Name = "panelDesktopForm";
            this.panelDesktopForm.Size = new System.Drawing.Size(800, 450);
            this.panelDesktopForm.TabIndex = 4;
            // 
            // label_ShutDownTime
            // 
            this.label_ShutDownTime.AutoSize = true;
            this.label_ShutDownTime.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShutDownTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(39)))), ((int)(((byte)(160)))));
            this.label_ShutDownTime.Location = new System.Drawing.Point(284, 104);
            this.label_ShutDownTime.Name = "label_ShutDownTime";
            this.label_ShutDownTime.Size = new System.Drawing.Size(102, 40);
            this.label_ShutDownTime.TabIndex = 6;
            this.label_ShutDownTime.Text = "label3";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(269, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "This computer will close in";
            // 
            // customedTextBox_eixtPassword
            // 
            this.customedTextBox_eixtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_eixtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_eixtPassword.BorderFocusColor = System.Drawing.Color.Indigo;
            this.customedTextBox_eixtPassword.BorderRadius = 0;
            this.customedTextBox_eixtPassword.BorderSize = 2;
            this.customedTextBox_eixtPassword.CausesValidation = false;
            this.customedTextBox_eixtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_eixtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_eixtPassword.Location = new System.Drawing.Point(188, 241);
            this.customedTextBox_eixtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_eixtPassword.Multiline = false;
            this.customedTextBox_eixtPassword.Name = "customedTextBox_eixtPassword";
            this.customedTextBox_eixtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_eixtPassword.PasswordChar = true;
            this.customedTextBox_eixtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_eixtPassword.PlaceholderText = "";
            this.customedTextBox_eixtPassword.Size = new System.Drawing.Size(417, 31);
            this.customedTextBox_eixtPassword.TabIndex = 4;
            this.customedTextBox_eixtPassword.Texts = "";
            this.customedTextBox_eixtPassword.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter exit password to cancel scheduled shutdown";
            // 
            // customedButton1
            // 
            this.customedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customedButton1.BorderRadius = 20;
            this.customedButton1.BorderSize = 0;
            this.customedButton1.FlatAppearance.BorderSize = 0;
            this.customedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customedButton1.ForeColor = System.Drawing.Color.White;
            this.customedButton1.Location = new System.Drawing.Point(305, 292);
            this.customedButton1.Name = "customedButton1";
            this.customedButton1.Size = new System.Drawing.Size(163, 48);
            this.customedButton1.TabIndex = 2;
            this.customedButton1.Text = "Cancel Scheduled Shutdown";
            this.customedButton1.TextColor = System.Drawing.Color.White;
            this.customedButton1.UseVisualStyleBackColor = false;
            this.customedButton1.Click += new System.EventHandler(this.customedButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopForm);
            this.Name = "Home";
            this.Text = "Home";
            this.panelDesktopForm.ResumeLayout(false);
            this.panelDesktopForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktopForm;
        private CoreUI.CustomedButton customedButton1;
        private CoreUI.CustomedTextBox customedTextBox_eixtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ShutDownTime;
    }
}