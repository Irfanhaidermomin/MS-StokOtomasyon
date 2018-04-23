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
    public partial class BorçEkle : Form
    {
        public BorçEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        BorcORM bOrm = new BorcORM();
        BORC borc = new BORC();

        /*#region get-set Gonderme
        public string adiSoyadi { get; set; }
        public string borcumuz { get; set; }
        //public string borcTarihi { get; set; }
        public string odemeTerihi { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; }
        #endregion*/

        public void Temizle()
        {
            cmbKimeAnd__ID.Text = "";
            txtBorcumuz.Clear();
            txtAdres.Clear();
            dateOdemeTar.Value = DateTime.Now;
            maskedTelNO.Text = "";
            cmbKimeAnd__ID.Focus();
        }
        private void cmbDoldur()
        {
            cmbKimeAnd__ID.DataSource = bOrm.SELECT();
            cmbKimeAnd__ID.DisplayMember = "ADISOYADI";
            cmbKimeAnd__ID.ValueMember = "ID";
        }
        #region get-set Gonderme
        public string adiSoyadi { get; set; }
        public string borcumuz { get; set; }
        public string odemeTar { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; } 
        #endregion
        #endregion
        private void BorçEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            #region get-set Gonderme
            cmbKimeAnd__ID.Text = adiSoyadi;
            txtBorcumuz.Text = borcumuz;
            dateOdemeTar.Text = odemeTar;
            maskedTelNO.Text = telNo;
            txtAdres.Text = adres; 
            #endregion
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                borc.ADISOYADI = cmbKimeAnd__ID.Text;
                borc.BORCUMUZ = txtBorcumuz.Text;
                borc.BORCTARIHI = DateTime.Now;
                borc.ODEMETARIHI = dateOdemeTar.Value;
                borc.TELNO = maskedTelNO.Text;
                borc.ADRES = txtAdres.Text;

                bool sonuc = bOrm.INSERT(borc);

                if (sonuc)
                {
                    MessageBox.Show("Borç Başarı ile Eklendi !", "Borç Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borç Ekleme Başarısız !", "Borç Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            borc.ID = Convert.ToInt32(cmbKimeAnd__ID.SelectedValue);

            bool sonuc = bOrm.DELETE(borc);

            if (sonuc)
            {
                MessageBox.Show("Borç Başarı ile Silindi !", "Borç Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Borç Silme Başarısız !", "Borç Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                borc.ID = Convert.ToInt32(cmbKimeAnd__ID.SelectedValue);
                borc.ADISOYADI = cmbKimeAnd__ID.Text;
                borc.BORCUMUZ = txtBorcumuz.Text;
                //borc.BORCTARIHI = DateTime.Now;
                borc.ODEMETARIHI = dateOdemeTar.Value;
                borc.TELNO = maskedTelNO.Text;
                borc.ADRES = txtAdres.Text;

                bool sonuc = bOrm.UPDATE(borc);

                if (sonuc)
                {
                    MessageBox.Show("Borç Başarı ile Güncellendi !", "Borç Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borç Güncelleme Başarısız !", "Borç Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void cmbKimeAnd__ID_TextChanged(object sender, EventArgs e)
        {
            #region Combobox Karakter Büyük Yazdırma
            int büyük = cmbKimeAnd__ID.SelectionStart;
            cmbKimeAnd__ID.Text = cmbKimeAnd__ID.Text.ToUpper();
            cmbKimeAnd__ID.SelectionStart = büyük; 
            #endregion
        }
    }
}
