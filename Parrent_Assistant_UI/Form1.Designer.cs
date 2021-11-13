
namespace Parrent_Assistant_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Contactusbutt = new System.Windows.Forms.Button();
            this.Settimerbutt = new System.Windows.Forms.Button();
            this.Homebutt = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.Settingbutt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ESCbutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(36)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 614);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlNav);
            this.panel3.Controls.Add(this.Contactusbutt);
            this.panel3.Controls.Add(this.Settimerbutt);
            this.panel3.Controls.Add(this.Homebutt);
            this.panel3.Controls.Add(this.Settingbutt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 422);
            this.panel3.TabIndex = 7;
            // 
            // Contactusbutt
            // 
            this.Contactusbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(36)))), ((int)(((byte)(172)))));
            this.Contactusbutt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Contactusbutt.FlatAppearance.BorderSize = 0;
            this.Contactusbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Contactusbutt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Contactusbutt.Image = ((System.Drawing.Image)(resources.GetObject("Contactusbutt.Image")));
            this.Contactusbutt.Location = new System.Drawing.Point(0, 114);
            this.Contactusbutt.Name = "Contactusbutt";
            this.Contactusbutt.Size = new System.Drawing.Size(261, 57);
            this.Contactusbutt.TabIndex = 6;
            this.Contactusbutt.Text = "Contact Us";
            this.Contactusbutt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Contactusbutt.UseVisualStyleBackColor = false;
            this.Contactusbutt.Click += new System.EventHandler(this.Contactusbutt_Click);
            this.Contactusbutt.Leave += new System.EventHandler(this.Contactusbutt_Leave);
            // 
            // Settimerbutt
            // 
            this.Settimerbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(36)))), ((int)(((byte)(172)))));
            this.Settimerbutt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settimerbutt.FlatAppearance.BorderSize = 0;
            this.Settimerbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settimerbutt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Settimerbutt.Image = ((System.Drawing.Image)(resources.GetObject("Settimerbutt.Image")));
            this.Settimerbutt.Location = new System.Drawing.Point(0, 57);
            this.Settimerbutt.Name = "Settimerbutt";
            this.Settimerbutt.Size = new System.Drawing.Size(261, 57);
            this.Settimerbutt.TabIndex = 5;
            this.Settimerbutt.Text = "SET TIMER";
            this.Settimerbutt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Settimerbutt.UseVisualStyleBackColor = false;
            this.Settimerbutt.Click += new System.EventHandler(this.Settimerbutt_Click);
            this.Settimerbutt.Leave += new System.EventHandler(this.Settimerbutt_Leave);
            // 
            // Homebutt
            // 
            this.Homebutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(36)))), ((int)(((byte)(172)))));
            this.Homebutt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Homebutt.FlatAppearance.BorderSize = 0;
            this.Homebutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Homebutt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Homebutt.Image = ((System.Drawing.Image)(resources.GetObject("Homebutt.Image")));
            this.Homebutt.Location = new System.Drawing.Point(0, 0);
            this.Homebutt.Name = "Homebutt";
            this.Homebutt.Size = new System.Drawing.Size(261, 57);
            this.Homebutt.TabIndex = 4;
            this.Homebutt.Text = "HOME";
            this.Homebutt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Homebutt.UseVisualStyleBackColor = false;
            this.Homebutt.Click += new System.EventHandler(this.Homebutt_Click);
            this.Homebutt.Leave += new System.EventHandler(this.Homebutt_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlNav.Location = new System.Drawing.Point(0, 1);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 170);
            this.pnlNav.TabIndex = 8;
            // 
            // Settingbutt
            // 
            this.Settingbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(36)))), ((int)(((byte)(172)))));
            this.Settingbutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settingbutt.FlatAppearance.BorderSize = 0;
            this.Settingbutt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settingbutt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Settingbutt.Image = ((System.Drawing.Image)(resources.GetObject("Settingbutt.Image")));
            this.Settingbutt.Location = new System.Drawing.Point(0, 365);
            this.Settingbutt.Name = "Settingbutt";
            this.Settingbutt.Size = new System.Drawing.Size(261, 57);
            this.Settingbutt.TabIndex = 7;
            this.Settingbutt.Text = "Setting";
            this.Settingbutt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Settingbutt.UseVisualStyleBackColor = false;
            this.Settingbutt.Click += new System.EventHandler(this.Settingbutt_Click);
            this.Settingbutt.Leave += new System.EventHandler(this.Settingbutt_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 192);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(260, 234);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(838, 380);
            this.PnlFormLoader.TabIndex = 6;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(80)))), ((int)(((byte)(199)))));
            this.Welcome.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Welcome.Location = new System.Drawing.Point(267, 28);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(406, 36);
            this.Welcome.TabIndex = 13;
            this.Welcome.Text = "WELCOME TO SCREENTAKE\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(225)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(556, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // ESCbutt
            // 
            this.ESCbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.ESCbutt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ESCbutt.ForeColor = System.Drawing.Color.Red;
            this.ESCbutt.Location = new System.Drawing.Point(1051, 12);
            this.ESCbutt.Name = "ESCbutt";
            this.ESCbutt.Size = new System.Drawing.Size(25, 23);
            this.ESCbutt.TabIndex = 16;
            this.ESCbutt.Text = "X";
            this.ESCbutt.UseVisualStyleBackColor = false;
            this.ESCbutt.Click += new System.EventHandler(this.ESCbutt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 614);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.ESCbutt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Settingbutt;
        private System.Windows.Forms.Button Contactusbutt;
        private System.Windows.Forms.Button Settimerbutt;
        private System.Windows.Forms.Button Homebutt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ESCbutt;
    }
}

