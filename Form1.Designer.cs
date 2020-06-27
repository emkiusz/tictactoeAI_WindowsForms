namespace tictactoeAI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pole1 = new System.Windows.Forms.PictureBox();
            this.pole3 = new System.Windows.Forms.PictureBox();
            this.pole2 = new System.Windows.Forms.PictureBox();
            this.pole4 = new System.Windows.Forms.PictureBox();
            this.pole5 = new System.Windows.Forms.PictureBox();
            this.pole6 = new System.Windows.Forms.PictureBox();
            this.pole7 = new System.Windows.Forms.PictureBox();
            this.pole9 = new System.Windows.Forms.PictureBox();
            this.pole8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole8)).BeginInit();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kółko, krzyżyk i sztuczna inteligencja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Powtórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::tictactoeAI.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(43, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pole1
            // 
            this.pole1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole1.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole1.Location = new System.Drawing.Point(43, 97);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(64, 64);
            this.pole1.TabIndex = 1;
            this.pole1.TabStop = false;
            this.pole1.Click += new System.EventHandler(this.pole1_Click);
            // 
            // pole3
            // 
            this.pole3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole3.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole3.Location = new System.Drawing.Point(179, 97);
            this.pole3.Name = "pole3";
            this.pole3.Size = new System.Drawing.Size(64, 64);
            this.pole3.TabIndex = 2;
            this.pole3.TabStop = false;
            this.pole3.Click += new System.EventHandler(this.pole3_Click);
            // 
            // pole2
            // 
            this.pole2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole2.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole2.Location = new System.Drawing.Point(111, 97);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(64, 64);
            this.pole2.TabIndex = 3;
            this.pole2.TabStop = false;
            this.pole2.Click += new System.EventHandler(this.pole2_Click);
            // 
            // pole4
            // 
            this.pole4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole4.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole4.Location = new System.Drawing.Point(43, 165);
            this.pole4.Name = "pole4";
            this.pole4.Size = new System.Drawing.Size(64, 64);
            this.pole4.TabIndex = 4;
            this.pole4.TabStop = false;
            this.pole4.Click += new System.EventHandler(this.pole4_Click);
            // 
            // pole5
            // 
            this.pole5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole5.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole5.Location = new System.Drawing.Point(111, 165);
            this.pole5.Name = "pole5";
            this.pole5.Size = new System.Drawing.Size(64, 64);
            this.pole5.TabIndex = 5;
            this.pole5.TabStop = false;
            this.pole5.Click += new System.EventHandler(this.pole5_Click);
            // 
            // pole6
            // 
            this.pole6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole6.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole6.Location = new System.Drawing.Point(179, 165);
            this.pole6.Name = "pole6";
            this.pole6.Size = new System.Drawing.Size(64, 64);
            this.pole6.TabIndex = 6;
            this.pole6.TabStop = false;
            this.pole6.Click += new System.EventHandler(this.pole6_Click);
            // 
            // pole7
            // 
            this.pole7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole7.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole7.Location = new System.Drawing.Point(43, 233);
            this.pole7.Name = "pole7";
            this.pole7.Size = new System.Drawing.Size(64, 64);
            this.pole7.TabIndex = 7;
            this.pole7.TabStop = false;
            this.pole7.Click += new System.EventHandler(this.pole7_Click);
            // 
            // pole9
            // 
            this.pole9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole9.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole9.Location = new System.Drawing.Point(179, 233);
            this.pole9.Name = "pole9";
            this.pole9.Size = new System.Drawing.Size(64, 64);
            this.pole9.TabIndex = 8;
            this.pole9.TabStop = false;
            this.pole9.Click += new System.EventHandler(this.pole9_Click);
            // 
            // pole8
            // 
            this.pole8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pole8.Image = global::tictactoeAI.Properties.Resources.blank;
            this.pole8.Location = new System.Drawing.Point(111, 233);
            this.pole8.Name = "pole8";
            this.pole8.Size = new System.Drawing.Size(64, 64);
            this.pole8.TabIndex = 9;
            this.pole8.TabStop = false;
            this.pole8.Click += new System.EventHandler(this.pole8_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tura gracza";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pole8);
            this.Controls.Add(this.pole9);
            this.Controls.Add(this.pole7);
            this.Controls.Add(this.pole6);
            this.Controls.Add(this.pole5);
            this.Controls.Add(this.pole4);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole3);
            this.Controls.Add(this.pole1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pole8;
        private System.Windows.Forms.PictureBox pole9;
        private System.Windows.Forms.PictureBox pole7;
        private System.Windows.Forms.PictureBox pole6;
        private System.Windows.Forms.PictureBox pole5;
        private System.Windows.Forms.PictureBox pole4;
        private System.Windows.Forms.PictureBox pole2;
        private System.Windows.Forms.PictureBox pole3;
        private System.Windows.Forms.PictureBox pole1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

