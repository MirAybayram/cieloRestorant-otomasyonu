﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cielo
{
    public partial class FrmKasaIslem : Form
    {
        public FrmKasaIslem()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Geri dönmek istediğize emin misiniz?", "UYARI !!!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Geri Dönülmedi.");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "UYARI !!!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış Yapılmadı.");
            }
        }
    }
}
