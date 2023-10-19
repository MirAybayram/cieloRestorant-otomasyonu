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
    public partial class FrmRezervasyon : Form
    {
        public FrmRezervasyon()
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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRezervasyon frm = new FrmRezervasyon();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    CieloContext db = new CieloContext();
        //    Rezervasyon r = db.Rezervasyon.Where(x => x.RezervasyonID == x.RezervasyonID).SingleOrDefault();
        //    r.Tarih =dtTarih.Value.ToShortDateTime(); 
        //    r.Masa = Convert.ToInt32(cbMasa.Text);
        //    r.KisiSayisi = cbKisiSayisi.Text();
        //    r.Durum = txtAciklama.Text;
           


         

        //    db.SaveChanges();
        //    this.DialogResult = DialogResult.OK;
        //    this.Dispose();
        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
