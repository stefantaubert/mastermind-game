namespace Mastermind
{
    partial class Colorrow
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.stecker1 = new System.Windows.Forms.PictureBox();
            this.stecker2 = new System.Windows.Forms.PictureBox();
            this.stecker3 = new System.Windows.Forms.PictureBox();
            this.stecker4 = new System.Windows.Forms.PictureBox();
            this.stift1 = new System.Windows.Forms.PictureBox();
            this.stift3 = new System.Windows.Forms.PictureBox();
            this.stift4 = new System.Windows.Forms.PictureBox();
            this.stift2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stecker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift2)).BeginInit();
            this.SuspendLayout();
            // 
            // stecker1
            // 
            this.stecker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stecker1.BackColor = System.Drawing.SystemColors.Control;
            this.stecker1.Location = new System.Drawing.Point(97, 3);
            this.stecker1.Name = "stecker1";
            this.stecker1.Size = new System.Drawing.Size(35, 32);
            this.stecker1.TabIndex = 0;
            this.stecker1.TabStop = false;
            // 
            // stecker2
            // 
            this.stecker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stecker2.Location = new System.Drawing.Point(138, 3);
            this.stecker2.Name = "stecker2";
            this.stecker2.Size = new System.Drawing.Size(35, 32);
            this.stecker2.TabIndex = 0;
            this.stecker2.TabStop = false;
            // 
            // stecker3
            // 
            this.stecker3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stecker3.Location = new System.Drawing.Point(179, 3);
            this.stecker3.Name = "stecker3";
            this.stecker3.Size = new System.Drawing.Size(35, 32);
            this.stecker3.TabIndex = 0;
            this.stecker3.TabStop = false;
            // 
            // stecker4
            // 
            this.stecker4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stecker4.Location = new System.Drawing.Point(220, 3);
            this.stecker4.Name = "stecker4";
            this.stecker4.Size = new System.Drawing.Size(35, 32);
            this.stecker4.TabIndex = 0;
            this.stecker4.TabStop = false;
            // 
            // stift1
            // 
            this.stift1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stift1.Location = new System.Drawing.Point(51, 3);
            this.stift1.Name = "stift1";
            this.stift1.Size = new System.Drawing.Size(16, 16);
            this.stift1.TabIndex = 1;
            this.stift1.TabStop = false;
            // 
            // stift3
            // 
            this.stift3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stift3.Location = new System.Drawing.Point(51, 19);
            this.stift3.Name = "stift3";
            this.stift3.Size = new System.Drawing.Size(16, 16);
            this.stift3.TabIndex = 1;
            this.stift3.TabStop = false;
            // 
            // stift4
            // 
            this.stift4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stift4.Location = new System.Drawing.Point(66, 19);
            this.stift4.Name = "stift4";
            this.stift4.Size = new System.Drawing.Size(16, 16);
            this.stift4.TabIndex = 1;
            this.stift4.TabStop = false;
            // 
            // stift2
            // 
            this.stift2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stift2.Location = new System.Drawing.Point(66, 3);
            this.stift2.Name = "stift2";
            this.stift2.Size = new System.Drawing.Size(16, 16);
            this.stift2.TabIndex = 1;
            this.stift2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The solution is:";
            // 
            // Colorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stift2);
            this.Controls.Add(this.stift4);
            this.Controls.Add(this.stift3);
            this.Controls.Add(this.stift1);
            this.Controls.Add(this.stecker4);
            this.Controls.Add(this.stecker3);
            this.Controls.Add(this.stecker2);
            this.Controls.Add(this.stecker1);
            this.Name = "Colorrow";
            this.Size = new System.Drawing.Size(305, 38);
            this.Load += new System.EventHandler(this.Farbreihe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stecker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stecker4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stift2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox stecker1;
        public System.Windows.Forms.PictureBox stecker2;
        public System.Windows.Forms.PictureBox stecker3;
        public System.Windows.Forms.PictureBox stecker4;
        public System.Windows.Forms.PictureBox stift1;
        public System.Windows.Forms.PictureBox stift3;
        public System.Windows.Forms.PictureBox stift4;
        public System.Windows.Forms.PictureBox stift2;
        public System.Windows.Forms.Label label1;

    }
}
