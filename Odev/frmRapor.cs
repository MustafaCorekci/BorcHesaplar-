using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            cbToplamBorc.Text = "ARTAN SIRALI OLARAK BORÇLUNUN AD,SOYAD ve TOPLAM BORCUNU GÖSTER";
            cbKalanBorc.Text = "KALAN BORÇ BAKIMINDAN EN YÜKSEKTEN EN DÜŞÜĞE AD,SOYAD ve KALAN BORCU GÖSTER";
            cbToplamOdeme.Text = "ÖDEME YAPAN MÜŞTERİLERİN TOPLAM ÖDEME MİKTARLARINI GÖSTER";
            cbSonOdeme.Text = "ÖDEMESİ BİTEN MÜŞTERİLERİN SON ÖDEMESİ NE ZAMAN YAPILMIŞ, GÖSTER";
        }

        private void cbToplamBorc_CheckedChanged(object sender, EventArgs e)
        {
            cbKalanBorc.Checked = false;
            cbToplamOdeme.Checked = false;
            cbSonOdeme.Checked = false;
        }

        private void cbKalanBorc_CheckedChanged(object sender, EventArgs e)
        {
            cbToplamBorc.Checked = false;
            cbToplamOdeme.Checked = false;
            cbSonOdeme.Checked = false;
        }

        private void cbToplamOdeme_CheckedChanged(object sender, EventArgs e)
        {
            cbToplamBorc.Checked = false;
            cbKalanBorc.Checked = false;
            cbSonOdeme.Checked = false;
        }

        private void cbSonOdeme_CheckedChanged(object sender, EventArgs e)
        {
            cbToplamBorc.Checked = false;
            cbKalanBorc.Checked = false;
            cbToplamOdeme.Checked = false;
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dtpBaslangic.Text) > DateTime.Parse(dtpBitis.Text))
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden Büyük Olamaz ! ! ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpBaslangic.Text = DateTime.Now.ToShortDateString();
                dtpBitis.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dtpBitis.Text) < DateTime.Parse(dtpBaslangic.Text))
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Küçük Olamaz ! ! ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpBaslangic.Text = DateTime.Now.ToShortDateString();
                dtpBitis.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            if (cbToplamBorc.Checked)
            {
                frmRaporGoruntule frm = new frmRaporGoruntule();
                frm.secilen = "ToplamBorc";
                frm.ShowDialog();
            }
            if (cbKalanBorc.Checked)
            {
                frmRaporGoruntule frm = new frmRaporGoruntule();
                frm.secilen = "KalanBorc";
                frm.ShowDialog();
            }
            if (cbToplamOdeme.Checked)
            {
                frmRaporGoruntule frm = new frmRaporGoruntule();
                frm.secilen = "ToplamOdeme";
                frm.ShowDialog();
            }
            if (cbSonOdeme.Checked)
            {
                frmRaporGoruntule frm = new frmRaporGoruntule();
                frm.secilen = "SonOdeme";
                frm.ShowDialog();
            }
        }
    }
}
