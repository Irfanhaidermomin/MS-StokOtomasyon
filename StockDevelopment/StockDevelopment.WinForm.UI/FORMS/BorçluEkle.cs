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
    public partial class BorçluEkle : Form
    {
        public BorçluEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        BorcluORM bOrm = new BorcluORM();
        BORCLU borclu = new BORCLU();

        public void Temizle()
        {
            txtAdres.Clear();
            txtBorcu.Clear();
            cmbAdiSoyadi__BorcID.Text = "";
            dateOdemeTar.Value = DateTime.Now;
            maskedTelNO.Text = "";
            cmbAdiSoyadi__BorcID.Focus();
        }
        private void cmbDoldur()
        {
            cmbAdiSoyadi__BorcID.DataSource = bOrm.SELECT();
            cmbAdiSoyadi__BorcID.DisplayMember = "ADISOYADI";
            cmbAdiSoyadi__BorcID.ValueMember = "ID";
        }
        #region get-set Gonderme
        public string adiSoyadi { get; set; }
        public string borcu { get; set; }
        public string odemeTar { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; } 
        #endregion
        #endregion
        
        private void BorçluEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            #region get-set Gonderme
            cmbAdiSoyadi__BorcID.Text = adiSoyadi;
            txtBorcu.Text = borcu;
            dateOdemeTar.Text = odemeTar;
            maskedTelNO.Text = telNo;
            txtAdres.Text = adres; 
            #endregion
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                borclu.ADISOYADI = cmbAdiSoyadi__BorcID.Text;
                borclu.BORCU = txtBorcu.Text;
                borclu.BORCTARIHI = DateTime.Now;
                borclu.ODEMETARIHI = dateOdemeTar.Value;
                borclu.TELNO = maskedTelNO.Text;
                borclu.ADRES = txtAdres.Text;

                bool sonuc = bOrm.INSERT(borclu);

                if (sonuc)
                {
                    MessageBox.Show("Borçlu Başarı ile Eklendi !", "Borçlu Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borçlu Başarı ile Eklendi !", "Borçlu Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
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
                borclu.ID = Convert.ToInt32(cmbAdiSoyadi__BorcID.SelectedValue);

                bool sonuc = bOrm.DELETE(borclu);

                if (sonuc)
                {
                    MessageBox.Show("Borçlu Başarı ile Silindi !", "Borçlu Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borçlu Silme Başarısız !", "Borçlu Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // ADISOYADI KISMI GÜNCELLENMİYOR !!!  BORÇ EKLEDE DE AYNISI VAR !!

                borclu.ID = Convert.ToInt32(cmbAdiSoyadi__BorcID.SelectedValue);
                borclu.ADISOYADI = cmbAdiSoyadi__BorcID.Text;
                borclu.BORCU = txtBorcu.Text;
                //borclu.BORCTARIHI = DateTime.Now;
                borclu.ODEMETARIHI = dateOdemeTar.Value;
                borclu.TELNO = maskedTelNO.Text;
                borclu.ADRES = txtAdres.Text;

                bool sonuc = bOrm.UPDATE(borclu);

                if (sonuc)
                {
                    MessageBox.Show("Borçlu Başarı ile Güncellendi !", "Borçlu Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Borçlu Güncelleme Başarısız !", "Borçlu Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
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
        private void cmbAdiSoyadi__BorcID_TextChanged(object sender, EventArgs e)
        {
            #region Comboboxtaki yazılan veriyi büyük yazdırma
            int büyük = cmbAdiSoyadi__BorcID.SelectionStart;
            cmbAdiSoyadi__BorcID.Text = cmbAdiSoyadi__BorcID.Text.ToUpper();
            cmbAdiSoyadi__BorcID.SelectionStart = büyük; 
            #endregion
        }  
    }
}
