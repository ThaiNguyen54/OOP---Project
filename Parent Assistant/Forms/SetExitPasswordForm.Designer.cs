
namespace Parent_Assistant.Forms
{
    partial class SetExitPasswordForm
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
            this.label_promt2 = new System.Windows.Forms.Label();
            this.label_OldPassword = new System.Windows.Forms.Label();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.checkBox_Save = new System.Windows.Forms.CheckBox();
            this.label_promt = new System.Windows.Forms.Label();
            this.customedButton_OK = new CoreUI.CustomedButton();
            this.customedTextBox_OldPassword = new CoreUI.CustomedTextBox();
            this.customedTextBox_NewPassword = new CoreUI.CustomedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.customedTextBox_NewPassword);
            this.panel1.Controls.Add(this.customedTextBox_OldPassword);
            this.panel1.Controls.Add(this.label_promt2);
            this.panel1.Controls.Add(this.label_OldPassword);
            this.panel1.Controls.Add(this.label_NewPassword);
            this.panel1.Controls.Add(this.checkBox_Save);
            this.panel1.Controls.Add(this.label_promt);
            this.panel1.Controls.Add(this.customedButton_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // label_promt2
            // 
            this.label_promt2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_promt2.AutoSize = true;
            this.label_promt2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_promt2.Location = new System.Drawing.Point(170, 109);
            this.label_promt2.Name = "label_promt2";
            this.label_promt2.Size = new System.Drawing.Size(355, 14);
            this.label_promt2.TabIndex = 11;
            this.label_promt2.Text = "In the case that you haven\'t set exit password yet, just leave it blank";
            // 
            // label_OldPassword
            // 
            this.label_OldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_OldPassword.AutoSize = true;
            this.label_OldPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_OldPassword.Location = new System.Drawing.Point(12, 63);
            this.label_OldPassword.Name = "label_OldPassword";
            this.label_OldPassword.Size = new System.Drawing.Size(100, 19);
            this.label_OldPassword.TabIndex = 9;
            this.label_OldPassword.Text = "Old password";
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_NewPassword.Location = new System.Drawing.Point(12, 195);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(105, 19);
            this.label_NewPassword.TabIndex = 8;
            this.label_NewPassword.Text = "New Password";
            // 
            // checkBox_Save
            // 
            this.checkBox_Save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Save.AutoSize = true;
            this.checkBox_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox_Save.FlatAppearance.BorderSize = 0;
            this.checkBox_Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.checkBox_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Save.Location = new System.Drawing.Point(173, 245);
            this.checkBox_Save.Name = "checkBox_Save";
            this.checkBox_Save.Size = new System.Drawing.Size(46, 17);
            this.checkBox_Save.TabIndex = 7;
            this.checkBox_Save.Text = "save";
            this.checkBox_Save.UseVisualStyleBackColor = true;
            // 
            // label_promt
            // 
            this.label_promt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_promt.AutoSize = true;
            this.label_promt.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_promt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_promt.Location = new System.Drawing.Point(261, 9);
            this.label_promt.Name = "label_promt";
            this.label_promt.Size = new System.Drawing.Size(259, 19);
            this.label_promt.TabIndex = 4;
            this.label_promt.Text = "Set exit password for exiting program";
            // 
            // customedButton_OK
            // 
            this.customedButton_OK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customedButton_OK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customedButton_OK.BorderRadius = 20;
            this.customedButton_OK.BorderSize = 0;
            this.customedButton_OK.FlatAppearance.BorderSize = 0;
            this.customedButton_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customedButton_OK.ForeColor = System.Drawing.Color.White;
            this.customedButton_OK.Location = new System.Drawing.Point(160, 303);
            this.customedButton_OK.Name = "customedButton_OK";
            this.customedButton_OK.Size = new System.Drawing.Size(84, 47);
            this.customedButton_OK.TabIndex = 3;
            this.customedButton_OK.Text = "OK";
            this.customedButton_OK.TextColor = System.Drawing.Color.White;
            this.customedButton_OK.UseVisualStyleBackColor = false;
            this.customedButton_OK.Click += new System.EventHandler(this.customedButton_OK_Click);
            // 
            // customedTextBox_OldPassword
            // 
            this.customedTextBox_OldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_OldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_OldPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customedTextBox_OldPassword.BorderRadius = 0;
            this.customedTextBox_OldPassword.BorderSize = 2;
            this.customedTextBox_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_OldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_OldPassword.Location = new System.Drawing.Point(173, 74);
            this.customedTextBox_OldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_OldPassword.Multiline = false;
            this.customedTextBox_OldPassword.Name = "customedTextBox_OldPassword";
            this.customedTextBox_OldPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_OldPassword.PasswordChar = true;
            this.customedTextBox_OldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_OldPassword.PlaceholderText = "";
            this.customedTextBox_OldPassword.Size = new System.Drawing.Size(347, 31);
            this.customedTextBox_OldPassword.TabIndex = 12;
            this.customedTextBox_OldPassword.Texts = "";
            this.customedTextBox_OldPassword.UnderlinedStyle = true;
            // 
            // customedTextBox_NewPassword
            // 
            this.customedTextBox_NewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_NewPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_NewPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customedTextBox_NewPassword.BorderRadius = 0;
            this.customedTextBox_NewPassword.BorderSize = 2;
            this.customedTextBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_NewPassword.Location = new System.Drawing.Point(173, 195);
            this.customedTextBox_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_NewPassword.Multiline = false;
            this.customedTextBox_NewPassword.Name = "customedTextBox_NewPassword";
            this.customedTextBox_NewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_NewPassword.PasswordChar = true;
            this.customedTextBox_NewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_NewPassword.PlaceholderText = "";
            this.customedTextBox_NewPassword.Size = new System.Drawing.Size(347, 31);
            this.customedTextBox_NewPassword.TabIndex = 13;
            this.customedTextBox_NewPassword.Texts = "";
            this.customedTextBox_NewPassword.UnderlinedStyle = true;
            // 
            // SetExitPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SetExitPasswordForm";
            this.Text = "Set Exit Password ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_Save;
        private System.Windows.Forms.Label label_promt;
        private CoreUI.CustomedButton customedButton_OK;
        private System.Windows.Forms.Label label_OldPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_promt2;
        private CoreUI.CustomedTextBox customedTextBox_NewPassword;
        private CoreUI.CustomedTextBox customedTextBox_OldPassword;
    }
}