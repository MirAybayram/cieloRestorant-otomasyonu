using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
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

        private void btnMasaİslemleri_Click(object sender, EventArgs e)
        {
            FrmMasalar frm = new FrmMasalar();
            frm.Show();
            this.Hide();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            FrmRezervasyon frm = new FrmRezervasyon();  
            frm.Show();
            this.Hide();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.Show();
            this.Hide();
        }

        private void btnKasaİslemleri_Click(object sender, EventArgs e)
        {
            FrmKasaIslem frm = new FrmKasaIslem();
            frm.Show();
            this.Hide();

        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            FrmMutfak frm = new FrmMutfak();
            frm.Show();
            this.Hide();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRapor frm = new FrmRapor();    
            frm.Show();
            this.Hide();

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar();
            frm.Show();
            this.Hide();
        }

        
    }
}
