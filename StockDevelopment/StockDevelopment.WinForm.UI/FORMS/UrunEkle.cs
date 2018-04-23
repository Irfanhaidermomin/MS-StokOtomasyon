using StockDevelopment.ORM;
using StockDevelopment.ORM.EntityLayer;
using StockDevelopment.ORM.FacadeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDevelopment.WinForm.UI.FORMS
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        UrunlerORM uOrm = new UrunlerORM();
        URUNLER urun = new URUNLER();

        public void Temizle()
        {
            txtAdi.Clear();
            txtAlisFiyat.Clear();
            cbmCinsi.Text = "";
            cmbKodu.Text = "";
            txtMiktar.Clear();
            txtSatisFiyat.Clear();
            cmbKodu.Focus();
        }
        private void cmbDoldur()
        {
            cmbKodu.DataSource = uOrm.SELECT();
            cmbKodu.DisplayMember = "URUNADI";
            cmbKodu.ValueMember = "URUNKODU";
        }

        #region get-set Gonderme
        public string urunKodu { get; set; }
        public string urunAdı { get; set; }
        public string urunMiktari { get; set; }
        public string urunCinsi { get; set; }
        public string alısFiyat { get; set; }
        public string satişFiyat { get; set; }
        #endregion
        #endregion
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            #region get-set Gonderme
            cmbKodu.Text = urunKodu;
            txtAdi.Text = urunAdı;
            txtMiktar.Text = urunMiktari;
            cbmCinsi.Text = urunCinsi;
            txtAlisFiyat.Text = alısFiyat;
            txtSatisFiyat.Text = satişFiyat;
            #endregion
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdi.Text == "" || txtAlisFiyat.Text == "" || cbmCinsi.Text == "" || cmbKodu.Text == "" || txtMiktar.Text == "" || txtSatisFiyat.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    #region Ürün Ekle

                    urun.URUNKODU = cmbKodu.Text;
                    urun.URUNADI = txtAdi.Text;
                    urun.URUNMIKTARI = txtMiktar.Text;
                    urun.URUNCINSI = cbmCinsi.Text;
                    urun.ALISTARIHI = DateTime.Now;
                    urun.ALISFIYAT = txtAlisFiyat.Text;
                    urun.SATISFIYAT = txtSatisFiyat.Text;

                    #region Eğer Ürün Aynı Fiyatsa Ürün Stoğunu Arttır
                    Tools.Baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM URUNLER WHERE URUNKODU='" + cmbKodu.Text + "'AND ALISFIYAT='" + txtAlisFiyat.Text + "'", Tools.Baglanti);
                    SqlDataReader dr = komut.ExecuteReader();

                    if (dr.HasRows)
                    {
                        SqlCommand komut2 = new SqlCommand("UPDATE URUNLER SET URUNMIKTARI=URUNMIKTARI+" + txtMiktar.Text + "WHERE URUNKODU='" + cmbKodu.Text + "'", Tools.Baglanti);
                        dr.Close();
                        komut2.ExecuteNonQuery();
                        Tools.Baglanti.Close();

                        MessageBox.Show("Ürün Başarı ile Eklendi !", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    #endregion
                    #region Eğer Ürün Aynı Fiyat Değilse Yeni Ürün Olarak Ekle
                    else
                    {
                        //dr.Close();

                        bool sonuc = uOrm.INSERT(urun);

                        if (sonuc)
                        {
                            MessageBox.Show("Ürün Başarı ile Eklendi !", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ürün Ekleme Başarısız !", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Temizle();
                        }
                        Tools.Baglanti.Close();
                    }
                }
                    #endregion
                    #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                urun.URUNKODU = Convert.ToString(cmbKodu.SelectedValue);

                bool sonuc = uOrm.DELETE(urun);

                if (sonuc)
                {
                    MessageBox.Show("Ürün Başarı ile Silindi !", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ürün Silme Başarısız !", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            urun.URUNKODU = cmbKodu.Text;
            urun.URUNADI = txtAdi.Text;
            urun.URUNMIKTARI = txtMiktar.Text;
            urun.URUNCINSI = cbmCinsi.Text;
            //urun.ALISTARIHI = DateTime.Now;
            urun.ALISFIYAT = txtAlisFiyat.Text;
            urun.SATISFIYAT = txtSatisFiyat.Text;

            #region Eğer Ürün Aynı Fiyatsa Ürün Stoğunu Arttır
            Tools.Baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM URUNLER WHERE URUNKODU='" + cmbKodu.Text + "'AND ALISFIYAT='" + txtAlisFiyat.Text + "'", Tools.Baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                SqlCommand komut2 = new SqlCommand("UPDATE URUNLER SET URUNMIKTARI=URUNMIKTARI+" + txtMiktar.Text + "WHERE URUNKODU='" + cmbKodu.Text + "'", Tools.Baglanti);
                dr.Close();
                komut2.ExecuteNonQuery();
                Tools.Baglanti.Close();

                MessageBox.Show("Ürün Başarı ile Güncellendi !", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            #endregion
            #region Eğer Ürün Aynı Fiyat Değilse Yeni Ürün Olarak Ekle
            else
            {
                //dr.Close();

                bool sonuc = uOrm.UPDATE(urun);

                if (sonuc)
                {
                    MessageBox.Show("Ürün Başarı ile Güncellendi !", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ürün Güncelleme Başarısız !", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
                Tools.Baglanti.Close();
            }
            #endregion
        }
    }
}