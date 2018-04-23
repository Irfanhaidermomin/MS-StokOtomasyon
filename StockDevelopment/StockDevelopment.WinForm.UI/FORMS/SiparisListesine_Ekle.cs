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
    public partial class SiparisListesine_Ekle : Form
    {
        public SiparisListesine_Ekle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        SiparisEdilecekORM sEdilecekOrm = new SiparisEdilecekORM();
        SIPARISEDILECEK edilecek = new SIPARISEDILECEK();

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
        private void cmbDoldur()
        {
            cmbUrunAdiAnd__ID.DataSource = sEdilecekOrm.SELECT();
            cmbUrunAdiAnd__ID.DisplayMember = "URUNADI";
            cmbUrunAdiAnd__ID.ValueMember = "ID";
            cmbUrunAdiAnd__ID.Text = "";
        } 
        #endregion
        private void SiparisListesine_Ekle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
        }
        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            edilecek.URUNADI = cmbUrunAdiAnd__ID.Text;
            edilecek.SIPARISTARIHI = DateTime.Now;
            edilecek.MIKTAR = txtMiktar.Text;

            bool sonuc = sEdilecekOrm.INSERT(edilecek);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilecek Listesine Başarı ile Eklendi !", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Sipariş Edilecek Listesine Ekleme Başarısız !", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            edilecek.ID = Convert.ToInt32(cmbUrunAdiAnd__ID.SelectedValue);

            bool sonuc = sEdilecekOrm.DELETE(edilecek);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilecek Listesinden Başarı ile Silindi!", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Sipariş Edilecek Listesinden Silme Başarısız !", "Sipariş Edilecek Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
