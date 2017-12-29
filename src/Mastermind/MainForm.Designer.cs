namespace Mastermind
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.stecker4 = new System.Windows.Forms.PictureBox();
            this.stecker3 = new System.Windows.Forms.PictureBox();
            this.stecker2 = new System.Windows.Forms.PictureBox();
            this.stecker1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stecker5 = new System.Windows.Forms.PictureBox();
            this.stecker6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.stecker4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(12, 338);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(211, 26);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "New row";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stecker4
            // 
            this.stecker4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker4.Location = new System.Drawing.Point(176, 1);
            this.stecker4.Name = "stecker4";
            this.stecker4.Size = new System.Drawing.Size(35, 32);
            this.stecker4.TabIndex = 3;
            this.stecker4.TabStop = false;
            this.stecker4.Click += new System.EventHandler(this.stecker4_Click);
            // 
            // stecker3
            // 
            this.stecker3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker3.Location = new System.Drawing.Point(135, 1);
            this.stecker3.Name = "stecker3";
            this.stecker3.Size = new System.Drawing.Size(35, 32);
            this.stecker3.TabIndex = 4;
            this.stecker3.TabStop = false;
            this.stecker3.Click += new System.EventHandler(this.stecker3_Click);
            // 
            // stecker2
            // 
            this.stecker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker2.Location = new System.Drawing.Point(94, 1);
            this.stecker2.Name = "stecker2";
            this.stecker2.Size = new System.Drawing.Size(35, 32);
            this.stecker2.TabIndex = 1;
            this.stecker2.TabStop = false;
            this.stecker2.Click += new System.EventHandler(this.stecker2_Click);
            // 
            // stecker1
            // 
            this.stecker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker1.BackColor = System.Drawing.SystemColors.Control;
            this.stecker1.Location = new System.Drawing.Point(53, 1);
            this.stecker1.Name = "stecker1";
            this.stecker1.Size = new System.Drawing.Size(35, 32);
            this.stecker1.TabIndex = 2;
            this.stecker1.TabStop = false;
            this.stecker1.Click += new System.EventHandler(this.stecker1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert:";
            // 
            // stecker5
            // 
            this.stecker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker5.Location = new System.Drawing.Point(217, 1);
            this.stecker5.Name = "stecker5";
            this.stecker5.Size = new System.Drawing.Size(35, 32);
            this.stecker5.TabIndex = 6;
            this.stecker5.TabStop = false;
            this.stecker5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stecker6
            // 
            this.stecker6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stecker6.Location = new System.Drawing.Point(258, 1);
            this.stecker6.Name = "stecker6";
            this.stecker6.Size = new System.Drawing.Size(35, 32);
            this.stecker6.TabIndex = 7;
            this.stecker6.TabStop = false;
            this.stecker6.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To plug:";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Plug 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Plug 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(177, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Plug 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(238, 39);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Plug 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(229, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stecker1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.stecker2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.stecker3);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.stecker4);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stecker5);
            this.panel1.Controls.Add(this.stecker6);
            this.panel1.Location = new System.Drawing.Point(12, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 56);
            this.panel1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 438);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mastermind";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stecker4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.PictureBox stecker4;
        public System.Windows.Forms.PictureBox stecker3;
        public System.Windows.Forms.PictureBox stecker2;
        public System.Windows.Forms.PictureBox stecker1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox stecker5;
        public System.Windows.Forms.PictureBox stecker6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

