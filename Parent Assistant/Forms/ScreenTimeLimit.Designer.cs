
namespace Parent_Assistant.Forms
{
    partial class ScreenTimeLimitForm
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
            this.customedTextBox_exitpassword = new CoreUI.CustomedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Second = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.checkBox_SaveTimeScreen = new System.Windows.Forms.CheckBox();
            this.label_CaptureScreenTime = new System.Windows.Forms.Label();
            this.customedButton_OK = new CoreUI.CustomedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.customedTextBox_exitpassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown_Second);
            this.panel1.Controls.Add(this.numericUpDown_Minutes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown_Hour);
            this.panel1.Controls.Add(this.checkBox_SaveTimeScreen);
            this.panel1.Controls.Add(this.label_CaptureScreenTime);
            this.panel1.Controls.Add(this.customedButton_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // customedTextBox_exitpassword
            // 
            this.customedTextBox_exitpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.customedTextBox_exitpassword.BorderColor = System.Drawing.Color.MediumBlue;
            this.customedTextBox_exitpassword.BorderFocusColor = System.Drawing.Color.Purple;
            this.customedTextBox_exitpassword.BorderRadius = 0;
            this.customedTextBox_exitpassword.BorderSize = 2;
            this.customedTextBox_exitpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customedTextBox_exitpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customedTextBox_exitpassword.Location = new System.Drawing.Point(270, 247);
            this.customedTextBox_exitpassword.Margin = new System.Windows.Forms.Padding(4);
            this.customedTextBox_exitpassword.Multiline = false;
            this.customedTextBox_exitpassword.Name = "customedTextBox_exitpassword";
            this.customedTextBox_exitpassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customedTextBox_exitpassword.PasswordChar = true;
            this.customedTextBox_exitpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customedTextBox_exitpassword.PlaceholderText = "";
            this.customedTextBox_exitpassword.Size = new System.Drawing.Size(250, 31);
            this.customedTextBox_exitpassword.TabIndex = 15;
            this.customedTextBox_exitpassword.Texts = "";
            this.customedTextBox_exitpassword.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(248, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter your exit password to save your setting";
            // 
            // numericUpDown_Second
            // 
            this.numericUpDown_Second.Location = new System.Drawing.Point(585, 78);
            this.numericUpDown_Second.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Second.Name = "numericUpDown_Second";
            this.numericUpDown_Second.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Second.TabIndex = 13;
            this.numericUpDown_Second.ValueChanged += new System.EventHandler(this.numericUpDown_Second_ValueChanged);
            // 
            // numericUpDown_Minutes
            // 
            this.numericUpDown_Minutes.Location = new System.Drawing.Point(333, 78);
            this.numericUpDown_Minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Minutes.Name = "numericUpDown_Minutes";
            this.numericUpDown_Minutes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Minutes.TabIndex = 12;
            this.numericUpDown_Minutes.ValueChanged += new System.EventHandler(this.numericUpDown_Minutes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(521, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(266, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hour";
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Location = new System.Drawing.Point(93, 78);
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Hour.TabIndex = 8;
            // 
            // checkBox_SaveTimeScreen
            // 
            this.checkBox_SaveTimeScreen.AutoSize = true;
            this.checkBox_SaveTimeScreen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox_SaveTimeScreen.FlatAppearance.BorderSize = 0;
            this.checkBox_SaveTimeScreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(162)))), ((int)(((byte)(175)))));
            this.checkBox_SaveTimeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_SaveTimeScreen.Location = new System.Drawing.Point(270, 285);
            this.checkBox_SaveTimeScreen.Name = "checkBox_SaveTimeScreen";
            this.checkBox_SaveTimeScreen.Size = new System.Drawing.Size(46, 17);
            this.checkBox_SaveTimeScreen.TabIndex = 7;
            this.checkBox_SaveTimeScreen.Text = "save";
            this.checkBox_SaveTimeScreen.UseVisualStyleBackColor = true;
            // 
            // label_CaptureScreenTime
            // 
            this.label_CaptureScreenTime.AutoSize = true;
            this.label_CaptureScreenTime.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CaptureScreenTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label_CaptureScreenTime.Location = new System.Drawing.Point(329, 9);
            this.label_CaptureScreenTime.Name = "label_CaptureScreenTime";
            this.label_CaptureScreenTime.Size = new System.Drawing.Size(127, 19);
            this.label_CaptureScreenTime.TabIndex = 4;
            this.label_CaptureScreenTime.Text = "Time Screen Limit";
            // 
            // customedButton_OK
            // 
            this.customedButton_OK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customedButton_OK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customedButton_OK.BorderRadius = 10;
            this.customedButton_OK.BorderSize = 0;
            this.customedButton_OK.FlatAppearance.BorderSize = 0;
            this.customedButton_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customedButton_OK.ForeColor = System.Drawing.Color.White;
            this.customedButton_OK.Location = new System.Drawing.Point(344, 369);
            this.customedButton_OK.Name = "customedButton_OK";
            this.customedButton_OK.Size = new System.Drawing.Size(99, 36);
            this.customedButton_OK.TabIndex = 3;
            this.customedButton_OK.Text = "OK";
            this.customedButton_OK.TextColor = System.Drawing.Color.White;
            this.customedButton_OK.UseVisualStyleBackColor = false;
            this.customedButton_OK.Click += new System.EventHandler(this.customedButton_OK_Click);
            // 
            // ScreenTimeLimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ScreenTimeLimitForm";
            this.Text = "Screen Time Limit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_SaveTimeScreen;
        private System.Windows.Forms.Label label_CaptureScreenTime;
        private CoreUI.CustomedButton customedButton_OK;
        private System.Windows.Forms.NumericUpDown numericUpDown_Second;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        private CoreUI.CustomedTextBox customedTextBox_exitpassword;
        private System.Windows.Forms.Label label4;
    }
}