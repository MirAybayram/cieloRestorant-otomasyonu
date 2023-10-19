namespace Cielo
{
    partial class Frmgiris
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxR1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2 = new System.Windows.Forms.PictureBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.txtSifre.Location = new System.Drawing.Point(62, 263);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(217, 24);
            this.txtSifre.TabIndex = 35;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(105, 349);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(110, 43);
            this.btnGiris.TabIndex = 34;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel2.Location = new System.Drawing.Point(31, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel1.Location = new System.Drawing.Point(31, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 31;
            // 
            // pictureBoxR1
            // 
            this.pictureBoxR1.BackgroundImage = global::Cielo.Properties.Resources.user1;
            this.pictureBoxR1.Location = new System.Drawing.Point(20, 206);
            this.pictureBoxR1.Name = "pictureBoxR1";
            this.pictureBoxR1.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxR1.TabIndex = 37;
            this.pictureBoxR1.TabStop = false;
            // 
            // pictureBoxR3
            // 
            this.pictureBoxR3.BackgroundImage = global::Cielo.Properties.Resources.logo1;
            this.pictureBoxR3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxR3.Location = new System.Drawing.Point(20, 65);
            this.pictureBoxR3.Name = "pictureBoxR3";
            this.pictureBoxR3.Size = new System.Drawing.Size(278, 87);
            this.pictureBoxR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxR3.TabIndex = 36;
            this.pictureBoxR3.TabStop = false;
            // 
            // pictureBoxR2
            // 
            this.pictureBoxR2.BackgroundImage = global::Cielo.Properties.Resources.password1;
            this.pictureBoxR2.Location = new System.Drawing.Point(20, 257);
            this.pictureBoxR2.Name = "pictureBoxR2";
            this.pictureBoxR2.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxR2.TabIndex = 32;
            this.pictureBoxR2.TabStop = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(64, 212);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(217, 24);
            this.txtKullaniciAdi.TabIndex = 38;
            // 
            // Frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(319, 456);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureBoxR1);
            this.Controls.Add(this.pictureBoxR3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxR2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmgiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxR1;
        private System.Windows.Forms.PictureBox pictureBoxR3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxR2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}