
namespace Parent_Assistant.Forms
{
    partial class ExitProgramForm
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
            this.customedTextBox_ExitPassword = new CoreUI.CustomedTextBox();
            this.label_ExitPassword = new System.Windows.Forms.Label();
            this.label_promt = new System.Windows.Forms.Label();
            this.customedButton_OK = new CoreUI.CustomedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.customedTextBox_ExitPassword);
            this.panel1.Controls.Add(this.label_ExitPassword);
            this.panel1.Controls.Add(this.label_promt);
            this.panel1.Controls.Add(this.customedButton_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // customedTextBox_ExitPassword
            // 
            this.customedTextBox_ExitPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_ExitPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customedTextBox_ExitPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customedTextBox_ExitPassword.BorderRadius = 0;
            this.customedTextBox_ExitPassword.BorderSize = 2;
            this.customedTextBox_ExitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_ExitPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_ExitPassword.Location = new System.Drawing.Point(160, 94);
            this.customedTextBox_ExitPassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_ExitPassword.Multiline = false;
            this.customedTextBox_ExitPassword.Name = "customedTextBox_ExitPassword";
            this.customedTextBox_ExitPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_ExitPassword.PasswordChar = true;
            this.customedTextBox_ExitPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_ExitPassword.PlaceholderText = "";
            this.customedTextBox_ExitPassword.Size = new System.Drawing.Size(259, 31);
            this.customedTextBox_ExitPassword.TabIndex = 11;
            this.customedTextBox_ExitPassword.Texts = "";
            this.customedTextBox_ExitPassword.UnderlinedStyle = true;
            // 
            // label_ExitPassword
            // 
            this.label_ExitPassword.AutoSize = true;
            this.label_ExitPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ExitPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_ExitPassword.Location = new System.Drawing.Point(12, 106);
            this.label_ExitPassword.Name = "label_ExitPassword";
            this.label_ExitPassword.Size = new System.Drawing.Size(100, 19);
            this.label_ExitPassword.TabIndex = 8;
            this.label_ExitPassword.Text = "Exit password";
            // 
            // label_promt
            // 
            this.label_promt.AutoSize = true;
            this.label_promt.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_promt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_promt.Location = new System.Drawing.Point(244, 9);
            this.label_promt.Name = "label_promt";
            this.label_promt.Size = new System.Drawing.Size(358, 19);
            this.label_promt.TabIndex = 4;
            this.label_promt.Text = "Enter exit password if you want to close the program";
            // 
            // customedButton_OK
            // 
            this.customedButton_OK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.customedButton_OK.BorderRadius = 0;
            this.customedButton_OK.BorderSize = 0;
            this.customedButton_OK.FlatAppearance.BorderSize = 0;
            this.customedButton_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customedButton_OK.ForeColor = System.Drawing.Color.White;
            this.customedButton_OK.Location = new System.Drawing.Point(160, 162);
            this.customedButton_OK.Name = "customedButton_OK";
            this.customedButton_OK.Size = new System.Drawing.Size(88, 41);
            this.customedButton_OK.TabIndex = 3;
            this.customedButton_OK.Text = "Exit";
            this.customedButton_OK.TextColor = System.Drawing.Color.White;
            this.customedButton_OK.UseVisualStyleBackColor = false;
            this.customedButton_OK.Click += new System.EventHandler(this.customedButton_OK_Click);
            // 
            // ExitProgramForm
            // 
            this.AcceptButton = this.customedButton_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ExitProgramForm";
            this.Text = "Exit Program";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ExitPassword;
        private System.Windows.Forms.Label label_promt;
        private CoreUI.CustomedButton customedButton_OK;
        private CoreUI.CustomedTextBox customedTextBox_ExitPassword;
    }
}