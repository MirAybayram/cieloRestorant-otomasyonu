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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
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
                FrmMusteri frm = new FrmMusteri();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Geri Dönülmedi.");
            }
        }

        private void btnMustGuncel_Click(object sender, EventArgs e)
        {
            CieloContext db = new CieloContext();
            Musteri m= db.Musteri.Where(x => x.MusteriID == x.MusteriID).SingleOrDefault();
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.Telefon = txtTelefon.Text;
            m.Email = txtEmail.Text;
    
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.Telefon = txtTelefon.Text;
            m.Email = txtEmail.Text;
            CieloContext db = new CieloContext();
            db.Musteri.Add(m);
            db.SaveChanges();
            MessageBox.Show(m.Ad + " " + m.Soyad + " adlı müşteri başarılı şekilde eklenmiştir :)", "Müşteri Eklendi", MessageBoxButtons.OK);


            Getir();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            Getir();
        }

        public void Getir()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
