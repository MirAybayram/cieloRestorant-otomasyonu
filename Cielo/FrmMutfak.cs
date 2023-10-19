using Cielo.Models;
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
    public partial class FrmMutfak : Form
    {
        public FrmMutfak()
        {
            InitializeComponent();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            CieloContext db = new CieloContext();
            Urun u = db.Urun.Where(x => x.UrunID == x.UrunID).SingleOrDefault();
            u.KategoriID = Convert.ToInt32(cbKategoriler.Text);
            u.UrunAdi =txtGidaAdi.Text;
            u.Fiyat= Convert.ToInt32(txtGidaFiyati.Text);


            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Dispose();


        }
    }
}
