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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        KullanıcıORM kOrm = new KullanıcıORM();
        KULLANICI user = new KULLANICI();

        public void Temizle()
        {
            txtAdi.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtGizliYanit.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSoyadi.Clear();
            maskedTelNO.Text = "";
            cmbTC.Text = "";
            cmbYetki.Text = "";
        }
        private void cmbDoldur()
        {
            cmbTC.DataSource = kOrm.SELECT();
            cmbTC.DisplayMember = "TC";
            cmbTC.Text = "";
        }
        #region GONDERME Get-Set

        public string tc { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string yetkisi { get; set; }
        public string gizli_yanit { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }

        #endregion 
        #endregion
        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            #region Gonderme get-set
            cmbTC.Text = tc;
            txtAdi.Text = adi;
            txtSoyadi.Text = soyadi;
            txtKullaniciAdi.Text = kullanici_adi;
            txtSifre.Text = sifre;
            cmbYetki.Text = yetkisi;
            txtGizliYanit.Text = gizli_yanit;
            txtEmail.Text = email;
            maskedTelNO.Text = telefon;
            txtAdres.Text = adres;
            #endregion
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Ekleme
            try
            {
                if (cmbTC.Text == "" || txtAdi.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || cmbYetki.Text == "" || txtGizliYanit.Text == "" || maskedTelNO.Text == "" || txtAdres.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    user.TC = cmbTC.Text;
                    user.ADI = txtAdi.Text;
                    user.SOYADI = txtSoyadi.Text;
                    user.KULLANICIADI = txtKullaniciAdi.Text;
                    user.SIFRE = txtSifre.Text;
                    user.YETKISI = cmbYetki.Text;
                    user.GIZLIYANIT = txtGizliYanit.Text;
                    user.EMAIL = txtEmail.Text;
                    user.TELNO = maskedTelNO.Text;
                    user.KAYITTARIHI = DateTime.Now;
                    user.ADRES = txtAdres.Text;

                    bool sonuc = kOrm.INSERT(user);

                    if (sonuc)
                    {
                        MessageBox.Show("Kullanıcı Başarı ile Eklendi !", "Kullanıcı Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        this.Dispose();
                        Kullanicilar kullaniciGör = new Kullanicilar();
                        kullaniciGör.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Ekleme Başarısız !", "Kullanıcı Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                user.TC = cmbTC.Text;

                bool sonuc = kOrm.DELETE(user);

                if (sonuc)
                {
                    MessageBox.Show("Kullanıcı Başarı ile Silindi !", "Kullanıcı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    //this.Dispose();
                    //Kullanicilar kullaniciGör = new Kullanicilar();
                    //kullaniciGör.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Silme Başarısız !", "Kullanıcı Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                user.TC = cmbTC.Text;
                user.ADI = txtAdi.Text;
                user.SOYADI = txtSoyadi.Text;
                user.KULLANICIADI = txtKullaniciAdi.Text;
                user.SIFRE = txtSifre.Text;
                user.YETKISI = cmbYetki.Text;
                user.GIZLIYANIT = txtGizliYanit.Text;
                user.EMAIL = txtEmail.Text;
                user.TELNO = maskedTelNO.Text;
                //user.KAYITTARIHI = DateTime.Now;
                user.ADRES = txtAdres.Text;

                bool sonuc = kOrm.UPDATE(user);

                if (sonuc)
                {
                    MessageBox.Show("Kullanıcı Başarı ile Güncellendi !", "Kullanıcı Güncellem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Güncelleme Başarısız !", "Kullanıcı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
