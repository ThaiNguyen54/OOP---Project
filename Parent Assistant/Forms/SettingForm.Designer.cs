
namespace Parent_Assistant.Forms
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Save = new System.Windows.Forms.CheckBox();
            this.label_SendMailTime = new System.Windows.Forms.Label();
            this.label_CaptureScreenTime = new System.Windows.Forms.Label();
            this.customedButton_OK = new CoreUI.CustomedButton();
            this.customedTextBox_SendMailTime = new CoreUI.CustomedTextBox();
            this.customedTextBox_CaptureTime = new CoreUI.CustomedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customedTextBox_password = new CoreUI.CustomedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.customedTextBox_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox_Save);
            this.panel1.Controls.Add(this.label_SendMailTime);
            this.panel1.Controls.Add(this.label_CaptureScreenTime);
            this.panel1.Controls.Add(this.customedButton_OK);
            this.panel1.Controls.Add(this.customedTextBox_SendMailTime);
            this.panel1.Controls.Add(this.customedTextBox_CaptureTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(90, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "If you haven\'t set email address yet, please set your email first at Email Addres" +
    "s tab";
            // 
            // checkBox_Save
            // 
            this.checkBox_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox_Save.FlatAppearance.BorderSize = 0;
            this.checkBox_Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.checkBox_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.checkBox_Save.Location = new System.Drawing.Point(249, 227);
            this.checkBox_Save.Name = "checkBox_Save";
            this.checkBox_Save.Size = new System.Drawing.Size(82, 20);
            this.checkBox_Save.TabIndex = 7;
            this.checkBox_Save.Text = "Save setting";
            this.checkBox_Save.UseVisualStyleBackColor = true;
            // 
            // label_SendMailTime
            // 
            this.label_SendMailTime.AutoSize = true;
            this.label_SendMailTime.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SendMailTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.label_SendMailTime.Location = new System.Drawing.Point(12, 102);
            this.label_SendMailTime.Name = "label_SendMailTime";
            this.label_SendMailTime.Size = new System.Drawing.Size(173, 19);
            this.label_SendMailTime.TabIndex = 5;
            this.label_SendMailTime.Text = "Send Mail Time (second)";
            // 
            // label_CaptureScreenTime
            // 
            this.label_CaptureScreenTime.AutoSize = true;
            this.label_CaptureScreenTime.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CaptureScreenTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.label_CaptureScreenTime.Location = new System.Drawing.Point(11, 25);
            this.label_CaptureScreenTime.Name = "label_CaptureScreenTime";
            this.label_CaptureScreenTime.Size = new System.Drawing.Size(207, 19);
            this.label_CaptureScreenTime.TabIndex = 4;
            this.label_CaptureScreenTime.Text = "Capture Screen Time (second)";
            // 
            // customedButton_OK
            // 
            this.customedButton_OK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customedButton_OK.BorderRadius = 20;
            this.customedButton_OK.BorderSize = 0;
            this.customedButton_OK.FlatAppearance.BorderSize = 0;
            this.customedButton_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customedButton_OK.ForeColor = System.Drawing.Color.White;
            this.customedButton_OK.Location = new System.Drawing.Point(12, 288);
            this.customedButton_OK.Name = "customedButton_OK";
            this.customedButton_OK.Size = new System.Drawing.Size(84, 47);
            this.customedButton_OK.TabIndex = 3;
            this.customedButton_OK.Text = "OK";
            this.customedButton_OK.TextColor = System.Drawing.Color.White;
            this.customedButton_OK.UseVisualStyleBackColor = false;
            this.customedButton_OK.Click += new System.EventHandler(this.customedButton_OK_Click);
            // 
            // customedTextBox_SendMailTime
            // 
            this.customedTextBox_SendMailTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_SendMailTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_SendMailTime.BorderFocusColor = System.Drawing.Color.GreenYellow;
            this.customedTextBox_SendMailTime.BorderRadius = 7;
            this.customedTextBox_SendMailTime.BorderSize = 2;
            this.customedTextBox_SendMailTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_SendMailTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_SendMailTime.Location = new System.Drawing.Point(249, 90);
            this.customedTextBox_SendMailTime.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_SendMailTime.Multiline = false;
            this.customedTextBox_SendMailTime.Name = "customedTextBox_SendMailTime";
            this.customedTextBox_SendMailTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_SendMailTime.PasswordChar = false;
            this.customedTextBox_SendMailTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_SendMailTime.PlaceholderText = "";
            this.customedTextBox_SendMailTime.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_SendMailTime.TabIndex = 1;
            this.customedTextBox_SendMailTime.Texts = "";
            this.customedTextBox_SendMailTime.UnderlinedStyle = false;
            // 
            // customedTextBox_CaptureTime
            // 
            this.customedTextBox_CaptureTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_CaptureTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_CaptureTime.BorderFocusColor = System.Drawing.Color.GreenYellow;
            this.customedTextBox_CaptureTime.BorderRadius = 7;
            this.customedTextBox_CaptureTime.BorderSize = 2;
            this.customedTextBox_CaptureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_CaptureTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_CaptureTime.Location = new System.Drawing.Point(249, 13);
            this.customedTextBox_CaptureTime.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_CaptureTime.Multiline = false;
            this.customedTextBox_CaptureTime.Name = "customedTextBox_CaptureTime";
            this.customedTextBox_CaptureTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_CaptureTime.PasswordChar = false;
            this.customedTextBox_CaptureTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_CaptureTime.PlaceholderText = "";
            this.customedTextBox_CaptureTime.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_CaptureTime.TabIndex = 0;
            this.customedTextBox_CaptureTime.Texts = "";
            this.customedTextBox_CaptureTime.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exit password";
            // 
            // customedTextBox_password
            // 
            this.customedTextBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_password.BorderFocusColor = System.Drawing.Color.GreenYellow;
            this.customedTextBox_password.BorderRadius = 7;
            this.customedTextBox_password.BorderSize = 2;
            this.customedTextBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_password.Location = new System.Drawing.Point(249, 189);
            this.customedTextBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_password.Multiline = false;
            this.customedTextBox_password.Name = "customedTextBox_password";
            this.customedTextBox_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_password.PasswordChar = true;
            this.customedTextBox_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_password.PlaceholderText = "";
            this.customedTextBox_password.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_password.TabIndex = 11;
            this.customedTextBox_password.Texts = "";
            this.customedTextBox_password.UnderlinedStyle = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CoreUI.CustomedTextBox customedTextBox_CaptureTime;
        private CoreUI.CustomedButton customedButton_OK;
        private CoreUI.CustomedTextBox customedTextBox_SendMailTime;
        private System.Windows.Forms.Label label_SendMailTime;
        private System.Windows.Forms.Label label_CaptureScreenTime;
        private System.Windows.Forms.CheckBox checkBox_Save;
        private System.Windows.Forms.Label label1;
        private CoreUI.CustomedTextBox customedTextBox_password;
        private System.Windows.Forms.Label label2;
    }
}