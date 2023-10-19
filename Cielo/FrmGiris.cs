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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            CieloContext db = new CieloContext();
            Personel m = db.Personel.Where(x => x.kullaniciAdi == txtKullaniciAdi.Text && x.parola == txtSifre.Text).SingleOrDefault();
            if (m == null)
            {
                MessageBox.Show("Personel Bulunamadı", "HATA", MessageBoxButtons.OK);
            }
            else if (m != null)
            {
                FrmMenu fm = new FrmMenu();
                fm.Show();
                this.Hide();
            }
        }
    }
}
