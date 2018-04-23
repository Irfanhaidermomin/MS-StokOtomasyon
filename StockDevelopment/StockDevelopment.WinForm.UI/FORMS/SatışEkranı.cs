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
    public partial class SatışEkranı : Form
    {
        public SatışEkranı()
        {
            InitializeComponent();
        }

        #region Global Tanımlar
        SatılanUrunORM satilanOrm = new SatılanUrunORM();
        UrunlerORM uOrm = new UrunlerORM();

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        SqlCommand komut = new SqlCommand();
        #endregion

        private void Temizle()
        {
            cmbUrunKodu.Text = "";
            txtAdi.Clear();
            txtAlisFiyat.Clear();
            txtMiktar.Clear();
            txtSatisFiyat.Clear();
            txtUrunCinsi.Clear();
        }

        private void SatışEkranı_Load(object sender, EventArgs e)
        {
            #region
            try
            {
                dataGridView1.DataSource = uOrm.SELECT();
                cmbUrunKodu.DataSource = uOrm.SELECT();
                cmbUrunKodu.DisplayMember = "URUNKODU";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void cmbUrunKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Seçilen Urun Koduna Göre Verileri TextBox'a Çekmesine Dair
            try
            {
                SqlCommand komut2 = new SqlCommand("SELECT * FROM URUNLER WHERE URUNKODU='" + cmbUrunKodu.Text + "'", baglanti);
                baglanti.Open();
                komut2.Connection = baglanti;
                komut2.ExecuteNonQuery();

                SqlDataReader dr = komut2.ExecuteReader();

                if (dr.Read())
                {
                    txtAdi.Text = dr["URUNADI"].ToString();
                    txtMiktar.Text = dr["URUNMIKTARI"].ToString();
                    txtUrunCinsi.Text = dr["URUNCINSI"].ToString();
                    //txtAdi.Text = dr["ALISTARIHI"].ToString(); ALIŞ TARİHİ HERHANGİ BİR TOOLDAN GİRİLMEDİĞİNDEN VERİ ÇEKİLMEYECEKTİR.
                    txtAlisFiyat.Text = dr["URUNADI"].ToString();
                    txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region DataGride Tıklandığında Verileri TextBox'a Aktar
            cmbUrunKodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunCinsi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAlisFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdi.Text == "" || txtAlisFiyat.Text == "" || txtUrunCinsi.Text == "" || cmbUrunKodu.Text == "" || txtMiktar.Text == "" || txtSatisFiyat.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    #region Ürünü Stoktan Düşürme
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = ("UPDATE URUNLER SET URUNMIKTARI=URUNMIKTARI-" + txtMiktar.Text + "WHERE URUNKODU='" + cmbUrunKodu.Text + "'");
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    #endregion

                    #region Ürünü SATILANURUN Tablosuna Ekleme
                    SATILANURUN satılan = new SATILANURUN();

                    satılan.URUNKODU = cmbUrunKodu.Text;
                    satılan.URUNADI = txtAdi.Text;
                    satılan.URUNMIKTARI = txtMiktar.Text;
                    satılan.URUNCINSI = txtUrunCinsi.Text;
                    satılan.SATISTARIHI = DateTime.Now;
                    satılan.ALISFIYAT = txtAlisFiyat.Text;
                    satılan.SATISFIYAT = txtSatisFiyat.Text;

                    Tools.Baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("SELECT * FROM SATILANURUN WHERE URUNKODU='" + cmbUrunKodu.Text + "'AND ALISFIYAT='" + txtAlisFiyat.Text + "'", Tools.Baglanti);
                    SqlDataReader dr = komut2.ExecuteReader();

                    if (dr.HasRows)
                    {
                        komut2 = new SqlCommand("UPDATE SATILANURUN SET URUNMIKTARI=URUNMIKTARI+" + txtMiktar.Text + "WHERE URUNKODU='" + cmbUrunKodu.Text + "'", Tools.Baglanti);
                        dr.Close();
                        komut2.ExecuteNonQuery();
                        Tools.Baglanti.Close();

                        MessageBox.Show("Ürün Başarı ile Satıldı !", "Ürün Satışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();

                        bool sonuc = satilanOrm.INSERT(satılan);

                        if (sonuc)
                        {
                            MessageBox.Show("Ürün Başarı ile Satıldı !", "Ürün Satışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ürün Satışı Başarısız !", "Ürün Satışı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Temizle();
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}