
namespace Parent_Assistant.Forms
{
    partial class EmailAddressForm
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
            this.checkBox_SaveEmail = new System.Windows.Forms.CheckBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.customedButton_OK = new CoreUI.CustomedButton();
            this.customedTextBox_EamilAddress = new CoreUI.CustomedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customedTextBox_exitpassword = new CoreUI.CustomedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customedTextBox_exitpassword);
            this.panel1.Controls.Add(this.checkBox_SaveEmail);
            this.panel1.Controls.Add(this.label_Email);
            this.panel1.Controls.Add(this.customedButton_OK);
            this.panel1.Controls.Add(this.customedTextBox_EamilAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // checkBox_SaveEmail
            // 
            this.checkBox_SaveEmail.AutoSize = true;
            this.checkBox_SaveEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox_SaveEmail.FlatAppearance.BorderSize = 0;
            this.checkBox_SaveEmail.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.checkBox_SaveEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_SaveEmail.Location = new System.Drawing.Point(266, 250);
            this.checkBox_SaveEmail.Name = "checkBox_SaveEmail";
            this.checkBox_SaveEmail.Size = new System.Drawing.Size(76, 17);
            this.checkBox_SaveEmail.TabIndex = 7;
            this.checkBox_SaveEmail.Text = "Save Email";
            this.checkBox_SaveEmail.UseVisualStyleBackColor = true;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_Email.Location = new System.Drawing.Point(223, 36);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(370, 19);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "We will send you email to this following email address";
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
            this.customedButton_OK.Location = new System.Drawing.Point(421, 264);
            this.customedButton_OK.Name = "customedButton_OK";
            this.customedButton_OK.Size = new System.Drawing.Size(84, 35);
            this.customedButton_OK.TabIndex = 3;
            this.customedButton_OK.Text = "OK";
            this.customedButton_OK.TextColor = System.Drawing.Color.White;
            this.customedButton_OK.UseVisualStyleBackColor = false;
            this.customedButton_OK.Click += new System.EventHandler(this.customedButton_OK_Click);
            // 
            // customedTextBox_EamilAddress
            // 
            this.customedTextBox_EamilAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_EamilAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_EamilAddress.BorderFocusColor = System.Drawing.Color.GreenYellow;
            this.customedTextBox_EamilAddress.BorderRadius = 7;
            this.customedTextBox_EamilAddress.BorderSize = 2;
            this.customedTextBox_EamilAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_EamilAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_EamilAddress.Location = new System.Drawing.Point(266, 59);
            this.customedTextBox_EamilAddress.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_EamilAddress.Multiline = false;
            this.customedTextBox_EamilAddress.Name = "customedTextBox_EamilAddress";
            this.customedTextBox_EamilAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_EamilAddress.PasswordChar = false;
            this.customedTextBox_EamilAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_EamilAddress.PlaceholderText = "";
            this.customedTextBox_EamilAddress.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_EamilAddress.TabIndex = 0;
            this.customedTextBox_EamilAddress.Texts = "";
            this.customedTextBox_EamilAddress.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(275, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter exit password to save change";
            // 
            // customedTextBox_exitpassword
            // 
            this.customedTextBox_exitpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_exitpassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_exitpassword.BorderFocusColor = System.Drawing.Color.GreenYellow;
            this.customedTextBox_exitpassword.BorderRadius = 7;
            this.customedTextBox_exitpassword.BorderSize = 2;
            this.customedTextBox_exitpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_exitpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_exitpassword.Location = new System.Drawing.Point(266, 212);
            this.customedTextBox_exitpassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_exitpassword.Multiline = false;
            this.customedTextBox_exitpassword.Name = "customedTextBox_exitpassword";
            this.customedTextBox_exitpassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_exitpassword.PasswordChar = true;
            this.customedTextBox_exitpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_exitpassword.PlaceholderText = "";
            this.customedTextBox_exitpassword.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_exitpassword.TabIndex = 8;
            this.customedTextBox_exitpassword.Texts = "";
            this.customedTextBox_exitpassword.UnderlinedStyle = true;
            // 
            // EmailAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmailAddressForm";
            this.Text = "Email Address";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_SaveEmail;
        private System.Windows.Forms.Label label_Email;
        private CoreUI.CustomedButton customedButton_OK;
        private CoreUI.CustomedTextBox customedTextBox_EamilAddress;
        private System.Windows.Forms.Label label1;
        private CoreUI.CustomedTextBox customedTextBox_exitpassword;
    }
}