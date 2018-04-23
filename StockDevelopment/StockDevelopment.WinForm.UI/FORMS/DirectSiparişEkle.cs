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
    public partial class DirectSiparişEkle : Form
    {
        public DirectSiparişEkle()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        SiparisEdilenORM sEdilenOrm = new SiparisEdilenORM();
        SIPARISEDILEN edilen = new SIPARISEDILEN();

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
            cmbUrunAdiAnd__ID.DataSource = sEdilenOrm.SELECT();
            cmbUrunAdiAnd__ID.DisplayMember = "URUNADI";
            cmbUrunAdiAnd__ID.ValueMember = "ID";
            cmbUrunAdiAnd__ID.Text = "";
        } 
        #endregion
        private void SiparişEkle_Load(object sender, EventArgs e)
        {
            cmbDoldur();
        }
        private void btnSiparisEt_Click(object sender, EventArgs e)
        {
            edilen.URUNADI = cmbUrunAdiAnd__ID.Text;
            edilen.SIPARISTARIHI = DateTime.Now;
            edilen.MIKTAR = txtMiktar.Text;

            bool sonuc = sEdilenOrm.INSERT(edilen);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilen Listesine Başarı ile Eklendi !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Sipariş Edilen Listesine Ekleme Başarısız !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            edilen.ID = Convert.ToInt32(cmbUrunAdiAnd__ID.SelectedValue);

            bool sonuc = sEdilenOrm.DELETE(edilen);

            if (sonuc)
            {
                MessageBox.Show("Sipariş Edilen Listesinden Başarı ile Silindi !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Sipariş Edilen Listesinden Silme Başarısız !", "Sipariş Edilen Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
