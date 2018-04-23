using StockDevelopment.ORM;
using StockDevelopment.ORM.EntityLayer;
using StockDevelopment.WinForm.UI.FORMS;
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
using System.IO;

namespace StockDevelopment.WinForm.UI
{
    public partial class GirişForm : Form
    {
        public GirişForm()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("BeniHatırla.txt");
            string hatırlanAd = reader.ReadToEnd();
            reader.Close();

            txtKullaniciAdi.Text = hatırlanAd;
        }
        
        SqlCommand komut;
        SqlDataReader dr;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (chckBeniHatirla.Checked == true)
                    {
                        #region BeniHatırla Özelliği
                        StreamWriter yazdır = new StreamWriter("BeniHatırla.txt");
                        yazdır.Write(txtKullaniciAdi.Text);
                        yazdır.Close();
                        #endregion
                    }
                    if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                    {
                        MessageBox.Show("Lütfen Boş Yerleri Doldurunuz !", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        #region Tam Yetki ADO.NET
                        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                        komut = new SqlCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT * FROM KULLANICI WHERE KULLANICIADI='" + txtKullaniciAdi.Text + "'AND SIFRE='" + txtSifre.Text + "'AND YETKISI='" + "ADMİN" + "'";
                        dr = komut.ExecuteReader();
                        #endregion

                        if (dr.Read())
                        {
                            MessageBox.Show("Giriş Başarılı !", "Yetkin Giriş !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            #region Tam Yetkili Kişinin Bütün MenuStriplere Ulaşmasına Dair
                            Program.a.menuStrip1.Enabled = true;
                            Program.a.referanslarToolStripMenuItem.Visible = true;
                            Program.a.veriTabanıToolStripMenuItem.Visible = true;
                            Program.a.defterToolStripMenuItem.Visible = true;
                            #endregion

                            this.Hide();

                            #region Yetkili Kişinin Kısayollara Erişmesi
                            Program.a.kullanıcıEkleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
                            Program.a.kullanıcılarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
                            Program.a.personelEkleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
                            Program.a.personellerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
                            Program.a.borçluHakkındaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
                            #endregion

                        }
                        else
                        {
                            #region Standart Yetki ADO.NET
                            baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                            komut = new SqlCommand();
                            baglanti.Open();
                            komut.Connection = baglanti;
                            komut.CommandText = "SELECT * FROM KULLANICI WHERE KULLANICIADI='" + txtKullaniciAdi.Text + "'AND SIFRE='" + txtSifre.Text + "'AND YETKISI='" + "STANDART" + "'";
                            dr = komut.ExecuteReader();
                            #endregion

                            if (dr.Read())
                            {
                                MessageBox.Show("STANDART YETKİ !", "Yetki Kısıtlaması !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                #region MenuStriplerin Standart Yetkiden Ötürü Gizlenmesi
                                Program.a.menuStrip1.Enabled = true;
                                Program.a.referanslarToolStripMenuItem.Visible = false;
                                Program.a.veriTabanıToolStripMenuItem.Visible = false;
                                Program.a.defterToolStripMenuItem.Visible = false;
                                #endregion

                                this.Hide();

                                #region Standart Yetkiden Ötürü Kısayol Tuşlarının Devredışı Bırakılması
                                Program.a.kullanıcıEkleToolStripMenuItem.ShortcutKeys = Keys.None;
                                Program.a.kullanıcılarToolStripMenuItem.ShortcutKeys = Keys.None;
                                Program.a.personelEkleToolStripMenuItem.ShortcutKeys = Keys.None;
                                Program.a.personellerToolStripMenuItem.ShortcutKeys = Keys.None;
                                Program.a.borçluHakkındaToolStripMenuItem.ShortcutKeys = Keys.None;
                                #endregion


                            }
                            else
                            {
                                txtKullaniciAdi.Clear();
                                txtSifre.Clear();
                                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Yeniden Giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtKullaniciAdi.Focus();
                            }
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum unuttum = new SifremiUnuttum();
            unuttum.Show();
        }

        private void GirişForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region Standart Yetkiden Ötürü Kısayol Tuşlarının Devredışı Bırakılması
                Program.a.kullanıcıEkleToolStripMenuItem.ShortcutKeys = Keys.None;
                Program.a.kullanıcılarToolStripMenuItem.ShortcutKeys = Keys.None;
                Program.a.personelEkleToolStripMenuItem.ShortcutKeys = Keys.None;
                Program.a.personellerToolStripMenuItem.ShortcutKeys = Keys.None;
                Program.a.borçluHakkındaToolStripMenuItem.ShortcutKeys = Keys.None;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }
    }
}