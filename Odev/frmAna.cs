using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        SqlBaglantisi bag = new SqlBaglantisi();
        Random random = new Random();
        string sifre = "";
        int sayi;
        bool kontrol;

        string[] dusuk = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

        string[] orta = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        string[] yuksek = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "?", "-", "_", ".", "!", "*", "+" };
        private string Value;

        //Kayıt varmı kontrol etme
        void Kontrol()
        {
            bag.baglanti();
            OleDbCommand komut = new OleDbCommand("Select * From Musteriler Where OzelSifre = @p1 or (Adi = @p2 and Soyadi = @p3)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSifre.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            bag.baglanti().Close();
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBorc.Text = "";
            txtSifre.Text = "";
            cmbSifrelemeTur.Text = "";
            txtAd.Focus();
        }

        void Listele()
        {
            //Datagridview verileri çekme
            bag.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Musteriler", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBilgiler.DataSource = dt;
            bag.baglanti().Close();

            //Hücreleri Renklendire İşlemleri
            for (int i = 0; i < dgvBilgiler.RowCount; i++)
            {
                dgvBilgiler.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                dgvBilgiler.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
            }
            for (int i = 0; i < dgvBilgiler.RowCount; i++)
            {
                dgvBilgiler.Rows[i].Cells[1].Style.BackColor = Color.LightBlue;
                dgvBilgiler.Rows[i].Cells[2].Style.BackColor = Color.LightBlue;
                dgvBilgiler.Rows[i].Cells[3].Style.BackColor = Color.LightBlue;
                dgvBilgiler.Rows[i].Cells[4].Style.BackColor = Color.LightBlue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bilgi Giriş Ekranı  |  " + DateTime.Now;

            btnSifreTuret.Enabled = false;
            txtSifre.Enabled = false;

            dgvBilgiler.AllowUserToAddRows = false;

            //Düzey bilgilerini çekme
            bag.baglanti();
            OleDbCommand komut = new OleDbCommand("Select * from Duzey", bag.baglanti());
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbSifrelemeTur.Items.Add(dr[0].ToString());
            }
            bag.baglanti().Close();

            //Datagridview verileri çekme
            Listele();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Bilgi Giriş Ekranı | " + DateTime.Now;
        }

        private void txtBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.TextLength > 10)
            {
                txtAd.Text = txtAd.Text.Substring(0, txtAd.Text.Length - 1);
                MessageBox.Show("10 Karakterden Fazla Giriş Yapılmaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtAd.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtSoyad.TextLength > 10)
            {
                txtSoyad.Text = txtSoyad.Text.Substring(0, txtSoyad.Text.Length - 1);
                MessageBox.Show("10 Karakterden Fazla Giriş Yapılmaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
        }

        private void cmbSifrelemeTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSifreTuret.Enabled = true;
        }

        private void btnSifreTuret_Click(object sender, EventArgs e)
        {
            sifre = "";

            if (cmbSifrelemeTur.Text == "Düşük Düzey")
            {
                for (int i = 0; i < 4; i++)
                {
                    sayi = random.Next(0, 24);
                    sifre += dusuk[sayi];
                }
                txtSifre.Text = sifre;
            }
            if (cmbSifrelemeTur.Text == "Orta Düzey")
            {
                for (int i = 0; i < 6; i++)
                {
                    sayi = random.Next(0, 33);
                    sifre += orta[sayi];
                }
                txtSifre.Text = sifre;
            }
            if (cmbSifrelemeTur.Text == "Yüksek Düzey")
            {
                for (int i = 0; i < 8; i++)
                {
                    sayi = random.Next(0, 40);
                    sifre += yuksek[sayi];
                }
                txtSifre.Text = sifre;
            }
        }

        private void btnSistemeYukle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" || txtSoyad.Text != "" || txtBorc.Text != "" || txtSifre.Text != "")
            {
                Kontrol();

                if (kontrol == false)
                {
                    if (MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " İÇİN " + txtBorc.Text + " TL Borç Kaydı Yapılsın mı ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bag.baglanti();
                        OleDbCommand komut = new OleDbCommand("insert into Musteriler (OzelSifre, Adi, Soyadi, ToplamBorc, KalanBorc, YuklemeTarihi) values (@p1, @p2, @p3, @p4, @p5, @p6)", bag.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                        komut.Parameters.AddWithValue("@p2", txtAd.Text);
                        komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                        komut.Parameters.AddWithValue("@p4", txtBorc.Text);
                        komut.Parameters.AddWithValue("@p5", txtBorc.Text);
                        komut.Parameters.AddWithValue("@p6", DateTime.Now.Date.ToString().TrimEnd('0', ':'));
                        komut.ExecuteNonQuery();
                        bag.baglanti().Close();
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    else
                    {
                        Temizle();
                        Listele();
                    }
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kayıt Daha Önce Oluşturulmuş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz ! ! !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Temizle();
        }

        private void dgvBilgiler_MouseDown(object sender, MouseEventArgs e)
        {
            Listele();
            if (e.Button == MouseButtons.Right)//farenin sağ tuşuna basılmışsa
            {
                int satir = dgvBilgiler.HitTest(e.X, e.Y).RowIndex;
                dgvBilgiler.Rows[satir].Selected = true;//bu tıkladığımız alanı seçtiriyoruz
                contextMenuStrip1.Show();
            }

        }

        OleDbCommand komut;
        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int secilen = dgvBilgiler.SelectedCells[0].RowIndex;

            if (InputBox.Show("Ne Kadar Ödeme Yapacaksınız ? ","Borç Ödeme",ref Value) == DialogResult.OK)
            {
                bag.baglanti();

                //Musteriler tablosundaki güncelleme işlemini yapıyor
                komut = new OleDbCommand("Update musteriler Set KalanBorc = KalanBorc - @p1 where OzelSifre = @p2", bag.baglanti());
                komut.Parameters.AddWithValue("@p1",Value);
                komut.Parameters.AddWithValue("@p2", dgvBilgiler.Rows[secilen].Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("Ödeme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Odeme yapan kişinin bilgilerini çekme
                komut = new OleDbCommand("Select Adi, Soyadi From Musteriler Where OzelSifre = @p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", dgvBilgiler.Rows[secilen].Cells[0].Value.ToString());
                OleDbDataReader dr1 = komut.ExecuteReader();
                if (dr1.Read())
                {
                    //Odemeler tablosundaki ekleme işlemi   
                    komut = new OleDbCommand("insert into Odemeler (Adi, Soyadi, OdemeMiktar, Tarih) values (@p1, @p2, @p3, @p4)",bag.baglanti());
                    komut.Parameters.AddWithValue("@p1", dr1[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dr1[1].ToString());
                    komut.Parameters.AddWithValue("@p3", Value);
                    komut.Parameters.AddWithValue("@p4", DateTime.Now);
                    komut.ExecuteNonQuery();

                    string dosyaYolu = @"C:\Users\musta\OneDrive\Masaüstü\C# Projects\Odev\odeme.txt";
                    string veri = dr1[0] + " \t\t" + dr1[1] + " \t" + Value + " \t" + DateTime.Now;
                    FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Close();
                    File.AppendAllText(dosyaYolu, Environment.NewLine + veri);
                }
                //Borcun bitip bitmediğini kontrol edicez
                komut = new OleDbCommand("Select KalanBorc,ToplamBorc From Musteriler Where OzelSifre = @p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", dgvBilgiler.Rows[secilen].Cells[0].Value.ToString());
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    int kalan = int.Parse(dr[0].ToString()) - int.Parse(Value);
                    if (kalan <= 0)
                    {
                        komut = new OleDbCommand("insert into OdemesiBitenler (Adi, Soyadi, ToplamBorc) values (@p1, @p2, @p3)", bag.baglanti());
                        komut.Parameters.AddWithValue("@p1", dr1[0].ToString());
                        komut.Parameters.AddWithValue("@p2", dr1[1].ToString());
                        komut.Parameters.AddWithValue("@p3", dr[1]);
                        komut.ExecuteNonQuery();

                        //Borcu biten kişidin musteriler tablosundan silme
                        komut = new OleDbCommand("Delete From musteriler where OzelSifre = @p1", bag.baglanti());
                        komut.Parameters.AddWithValue("@p1", dgvBilgiler.Rows[secilen].Cells[0].Value.ToString());
                        komut.ExecuteNonQuery();
                        Listele();
                    }
                }
                Listele();
                bag.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Ödeme İşlemi İptal Edildi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.ShowDialog();
        }
    }
}
