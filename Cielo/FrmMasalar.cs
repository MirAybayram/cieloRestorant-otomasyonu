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
    public partial class FrmMasalar : Form
    {
        public FrmMasalar()
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

        private void btnPencere1_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnPencere1.Text.Length;
            cGenel._ButtonValue = btnPencere1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnPencere1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnPencere2_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnPencere2.Text.Length;
            cGenel._ButtonValue = btnPencere2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnPencere2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnPencere3_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnPencere3.Text.Length;
            cGenel._ButtonValue = btnPencere3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnPencere3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnPencere4_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnPencere4.Text.Length;
            cGenel._ButtonValue = btnPencere4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnPencere4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnOrta1_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnOrta1.Text.Length;
            cGenel._ButtonValue = btnOrta1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnOrta1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnOrta2_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnOrta2.Text.Length;
            cGenel._ButtonValue = btnOrta2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnOrta2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnOrta3_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnOrta3.Text.Length;
            cGenel._ButtonValue = btnOrta3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnOrta3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnOrta4_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnOrta4.Text.Length;
            cGenel._ButtonValue = btnOrta4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnOrta4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnBalkon1_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnBalkon1.Text.Length;
            cGenel._ButtonValue = btnBalkon1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnBalkon1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnBalkon2_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnBalkon2.Text.Length;
            cGenel._ButtonValue = btnBalkon2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnBalkon2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnBalkon3_Click(object sender, EventArgs e)
        {

            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnBalkon3.Text.Length;
            cGenel._ButtonValue = btnBalkon3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnBalkon3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnBalkon4_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis();
            int uzunluk = btnBalkon4.Text.Length;
            cGenel._ButtonValue = btnBalkon4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnBalkon4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void FrmMasalar_Load(object sender, EventArgs e)
        {
           



        }
    }
}
