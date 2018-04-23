using StockDevelopment.ORM.EntityLayer;
using StockDevelopment.ORM.FacadeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDevelopment.WinForm.UI.FORMS
{
    public partial class SiparişEkle : Form
    {
        public SiparişEkle()
        {
            InitializeComponent();
        }

        SiparisEdilecekORM sEdilecekOrm = new SiparisEdilecekORM();
        SiparisEdilenORM sEdilenOrm = new SiparisEdilenORM();

        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void btnSiparisEt_Click(object sender, EventArgs e)
        {
            SIPARISEDILEN edilen = new SIPARISEDILEN();

            edilen.URUNADI = txtAdi.Text;
            edilen.SIPARISTARIHI = DateTime.Now;
            edilen.MIKTAR = txtMiktar.Text;

            bool sonuc = sEdilenOrm.INSERT(edilen);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilen Listesine Başarı ile Eklendi !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sipariş Edilen Listesine Ekleme Başarısız !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            SIPARISEDILECEK edilecek = new SIPARISEDILECEK();

            edilecek.URUNADI = txtAdi.Text;
            edilecek.SIPARISTARIHI = DateTime.Now;
            edilecek.MIKTAR = txtMiktar.Text;

            bool sonuc = sEdilecekOrm.INSERT(edilecek);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilecek Listesine Başarı ile Eklendi !", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sipariş Edilecek Listesine Ekleme Başarısız !", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
