namespace Cielo
{
    partial class FrmSiparisBil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisBil));
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.cbIndirim = new System.Windows.Forms.CheckBox();
            this.gbOdemeTuru = new System.Windows.Forms.GroupBox();
            this.rbIndirim = new System.Windows.Forms.RadioButton();
            this.gbOzel = new System.Windows.Forms.GroupBox();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOdemeBil = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnOzet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.gbIndirim.SuspendLayout();
            this.gbOdemeTuru.SuspendLayout();
            this.gbOzel.SuspendLayout();
            this.gbOdemeBil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIndirim
            // 
            this.gbIndirim.Controls.Add(this.cbIndirim);
            this.gbIndirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIndirim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIndirim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbIndirim.Location = new System.Drawing.Point(460, 55);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(152, 80);
            this.gbIndirim.TabIndex = 0;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel İndirim";
            // 
            // cbIndirim
            // 
            this.cbIndirim.AutoSize = true;
            this.cbIndirim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIndirim.Location = new System.Drawing.Point(17, 35);
            this.cbIndirim.Name = "cbIndirim";
            this.cbIndirim.Size = new System.Drawing.Size(122, 20);
            this.cbIndirim.TabIndex = 0;
            this.cbIndirim.Text = "İndirim Uygula";
            this.cbIndirim.UseVisualStyleBackColor = true;
            // 
            // gbOdemeTuru
            // 
            this.gbOdemeTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.gbOdemeTuru.Controls.Add(this.rbIndirim);
            this.gbOdemeTuru.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbOdemeTuru.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOdemeTuru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOdemeTuru.Location = new System.Drawing.Point(339, 274);
            this.gbOdemeTuru.Name = "gbOdemeTuru";
            this.gbOdemeTuru.Size = new System.Drawing.Size(128, 112);
            this.gbOdemeTuru.TabIndex = 0;
            this.gbOdemeTuru.TabStop = false;
            this.gbOdemeTuru.Text = "Ödeme Türü";
            // 
            // rbIndirim
            // 
            this.rbIndirim.AutoSize = true;
            this.rbIndirim.Location = new System.Drawing.Point(25, 22);
            this.rbIndirim.Name = "rbIndirim";
            this.rbIndirim.Size = new System.Drawing.Size(60, 20);
            this.rbIndirim.TabIndex = 2;
            this.rbIndirim.TabStop = true;
            this.rbIndirim.Text = "Nakit";
            this.rbIndirim.UseVisualStyleBackColor = true;
            // 
            // gbOzel
            // 
            this.gbOzel.Controls.Add(this.txtIndirimTutari);
            this.gbOzel.Controls.Add(this.label10);
            this.gbOzel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOzel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOzel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOzel.Location = new System.Drawing.Point(460, 150);
            this.gbOzel.Name = "gbOzel";
            this.gbOzel.Size = new System.Drawing.Size(182, 80);
            this.gbOzel.TabIndex = 0;
            this.gbOzel.TabStop = false;
            this.gbOzel.Text = "Özel Aktivite";
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(33, 48);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(100, 23);
            this.txtIndirimTutari.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "İndirim Tutarı Giriniz :";
            // 
            // gbOdemeBil
            // 
            this.gbOdemeBil.Controls.Add(this.label7);
            this.gbOdemeBil.Controls.Add(this.label4);
            this.gbOdemeBil.Controls.Add(this.label11);
            this.gbOdemeBil.Controls.Add(this.label9);
            this.gbOdemeBil.Controls.Add(this.label8);
            this.gbOdemeBil.Controls.Add(this.label6);
            this.gbOdemeBil.Controls.Add(this.label12);
            this.gbOdemeBil.Controls.Add(this.label5);
            this.gbOdemeBil.Controls.Add(this.label3);
            this.gbOdemeBil.Controls.Add(this.label2);
            this.gbOdemeBil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOdemeBil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOdemeBil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOdemeBil.Location = new System.Drawing.Point(53, 266);
            this.gbOdemeBil.Name = "gbOdemeBil";
            this.gbOdemeBil.Size = new System.Drawing.Size(256, 123);
            this.gbOdemeBil.TabIndex = 0;
            this.gbOdemeBil.TabStop = false;
            this.gbOdemeBil.Text = "Ödeme Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "İndirim";
            this.label12.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ara Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(49, 56);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(386, 174);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün ID";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış ID";
            this.columnHeader5.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siparişler";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCikis.BackgroundImage = global::Cielo.Properties.Resources.exit;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(64, 418);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(43, 45);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnGeriDon.BackgroundImage = global::Cielo.Properties.Resources.up_left_64px;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(16, 418);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(42, 45);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnOzet
            // 
            this.btnOzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.btnOzet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOzet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOzet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOzet.ImageKey = "bul.png";
            this.btnOzet.ImageList = this.ımageList1;
            this.btnOzet.Location = new System.Drawing.Point(528, 266);
            this.btnOzet.Name = "btnOzet";
            this.btnOzet.Size = new System.Drawing.Size(114, 53);
            this.btnOzet.TabIndex = 12;
            this.btnOzet.Text = "HESAP\r\n ÖZETİ";
            this.btnOzet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOzet.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bul.png");
            this.ımageList1.Images.SetKeyName(1, "aa.png");
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(233)))), ((int)(((byte)(148)))));
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapKapat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapKapat.ImageKey = "aa.png";
            this.btnHesapKapat.ImageList = this.ımageList1;
            this.btnHesapKapat.Location = new System.Drawing.Point(528, 341);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(114, 53);
            this.btnHesapKapat.TabIndex = 12;
            this.btnHesapKapat.Text = "HESAP\r\nKAPAT";
            this.btnHesapKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // FrmSiparisBil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnOzet);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.gbOdemeBil);
            this.Controls.Add(this.gbOzel);
            this.Controls.Add(this.gbOdemeTuru);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSiparisBil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSiparisBil";
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.gbOdemeTuru.ResumeLayout(false);
            this.gbOdemeTuru.PerformLayout();
            this.gbOzel.ResumeLayout(false);
            this.gbOzel.PerformLayout();
            this.gbOdemeBil.ResumeLayout(false);
            this.gbOdemeBil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.GroupBox gbOdemeTuru;
        private System.Windows.Forms.GroupBox gbOzel;
        private System.Windows.Forms.GroupBox gbOdemeBil;
        private System.Windows.Forms.CheckBox cbIndirim;
        private System.Windows.Forms.RadioButton rbIndirim;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnOzet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnHesapKapat;
    }
}