using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Odev
{
    public partial class frmRaporGoruntule : Form
    {
        public frmRaporGoruntule()
        {
            InitializeComponent();
        }

        SqlBaglantisi bag = new SqlBaglantisi();
        
        public string secilen;

        private void frmRaporGoruntule_Load(object sender, EventArgs e)
        {
            if (secilen == "ToplamBorc")
            {
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                //Borçlunun adı, soyadı, toplam borç bilgileri
                this.MusterilerTableAdapter.Fill(this.bilgilerDataSet.Musteriler);
                this.reportViewer1.RefreshReport();
            }
            if (secilen == "KalanBorc")
            {
                reportViewer1.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                //Borçlunun adı, soyadı, toplam borç bilgileri
                this.MusterilerTableAdapter.FillBy(this.bilgilerDataSet.Musteriler);
                this.reportViewer2.RefreshReport();
            }
            if (secilen == "ToplamOdeme")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer4.Visible = false;
                //Borçlunun adı, soyadı, toplam ödeme sbilgileri
                this.OdemelerTableAdapter.Fill(this.bilgilerDataSet1.Odemeler);
                this.reportViewer3.RefreshReport();
            }
            if (secilen == "SonOdeme")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                //Borçlunun adı, soyadı, son ödeme tarih bilgileri
                this.OdemesiBitenlerTableAdapter.FillSonOdeme(this.bilgilerDataSet2.OdemesiBitenler);
                this.reportViewer4.RefreshReport();
            }
        }
    }
}
