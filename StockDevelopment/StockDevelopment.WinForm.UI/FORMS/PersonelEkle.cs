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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        PersonelORM pOrm = new PersonelORM();
        PERSONEL personel = new PERSONEL();
        
        public void Temizle()
        {
            txtAdi.Clear();
            txtAdres.Clear();
            txtMaas.Clear();
            txtSoyadi.Clear();
            mskdTelNo.Text = "";
            dateBaslamaTar.Value = DateTime.Now;
            cmbMedeniHal.Text = "";
            cmbTC.Text = "";
        }
        private void cmbDoldur()
        {
            cmbTC.DataSource = pOrm.SELECT();
            cmbTC.DisplayMember = "TC";
            cmbTC.Text = "";
        } 
        #region Get-Set Göderme
        public string tc { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string maas { get; set; }
        public string telno { get; set; }
        public string baslamaTar { get; set; }
        public string medeniHal { get; set; }
        public string adres { get; set; }
        #endregion
        #endregion
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            #region get-set Gönderme
            cmbTC.Text = tc;
            txtAdi.Text = adi;
            txtSoyadi.Text = soyadi;
            txtMaas.Text = maas;
            mskdTelNo.Text = telno;
            dateBaslamaTar.Text = baslamaTar;
            cmbMedeniHal.Text = medeniHal;
            txtAdres.Text = adres;
            #endregion
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                #region Personel Ekleme
                if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtMaas.Text == "" || mskdTelNo.Text == "" || txtAdres.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    personel.TC = cmbTC.Text;
                    personel.ADI = txtAdi.Text;
                    personel.SOYADI = txtSoyadi.Text;
                    personel.MAAS = txtMaas.Text;
                    personel.TELNO = mskdTelNo.Text;
                    personel.BASLAMATARIHI = dateBaslamaTar.Value;
                    personel.MEDENIHAL = cmbMedeniHal.Text;
                    personel.ADRES = txtAdres.Text;

                    bool sonuc = pOrm.INSERT(personel);

                    if (sonuc)
                    {
                        MessageBox.Show("Personel Başarı ile Eklendi !", "Personel Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        //this.Dispose();
                        //Personeller personelGör = new Personeller();
                        //personelGör.Show();
                    }
                    else
                    {
                        MessageBox.Show("Personel Ekleme Başarısız !", "Personel Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                } 
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
                personel.TC = cmbTC.Text;

                bool sonuc = pOrm.DELETE(personel);

                if (sonuc)
                {
                    MessageBox.Show("Personel Silme Başarılı !", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Personel Silme Başarısız !", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                personel.TC = cmbTC.Text;
                personel.ADI = txtAdi.Text;
                personel.SOYADI = txtSoyadi.Text;
                personel.MAAS = txtMaas.Text;
                personel.TELNO = mskdTelNo.Text;
                personel.BASLAMATARIHI = dateBaslamaTar.Value;
                personel.MEDENIHAL = cmbMedeniHal.Text;
                personel.ADRES = txtAdres.Text;

                bool sonuc = pOrm.UPDATE(personel);

                if (sonuc)
                {
                    MessageBox.Show("Personel Başarı ile Eklendi !", "Personel Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Personel Ekleme Başarısız !", "Personel Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
