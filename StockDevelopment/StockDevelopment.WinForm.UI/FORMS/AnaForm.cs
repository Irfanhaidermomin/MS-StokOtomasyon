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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            giriş = new GirişForm();
            giriş.MdiParent = this;
            giriş.Show();
        }
        public static GirişForm giriş;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz ?", "Dikkat !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                menuStrip1.Enabled = false;
                giriş = new GirişForm();
                giriş.MdiParent = this;
                giriş.Show();
                giriş.txtKullaniciAdi.Focus();
            }
        }
        public static KullaniciEkle k_Ekle;
        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            k_Ekle = new KullaniciEkle();
            k_Ekle.MdiParent = this;
            k_Ekle.Show();
        }
        public static Kullanicilar kullanicilar;
        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            kullanicilar = new Kullanicilar();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }
        public static Personeller personel;
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            personel = new Personeller();
            personel.MdiParent = this;
            personel.Show();
        }
        public static PersonelEkle eklePersonel;
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            eklePersonel = new PersonelEkle();
            eklePersonel.MdiParent = this;
            eklePersonel.Show();
        }
        public static UrunEkle urunEkle;
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            urunEkle = new UrunEkle();
            urunEkle.MdiParent = this;
            urunEkle.Show();
        }
        public static Urunler urunGör;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            urunGör = new Urunler();
            urunGör.MdiParent = this;
            urunGör.Show();
        }
        public static AzalanÜrünler azalanÜrün;
        private void azalanÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            azalanÜrün = new AzalanÜrünler();
            azalanÜrün.MdiParent = this;
            azalanÜrün.Show();
        }
        public static StokBilgi stokBilgi;
        private void stokBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            stokBilgi = new StokBilgi();
            stokBilgi.MdiParent = this;
            stokBilgi.Show();
        }
        public static SatışEkranı satis;
        private void satışEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            satis = new SatışEkranı();
            satis.MdiParent = this;
            satis.Show();
        }
        public static SatılanMal satılmışMal;
        private void satılanMalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            satılmışMal = new SatılanMal();
            satılmışMal.MdiParent = this;
            satılmışMal.Show();
        }
        public static AlınanMal alınmışMal;
        private void alınanMalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            alınmışMal = new AlınanMal();
            alınmışMal.MdiParent = this;
            alınmışMal.Show();
        }
        public static DirectSiparişEkle spEkle;
        private void DirectsiparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            spEkle = new DirectSiparişEkle();
            spEkle.MdiParent = this;
            spEkle.Show();
        }
        public static SiparişEdilecekListesi sEdilecek;
        private void siparişEdilecekListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            sEdilecek = new SiparişEdilecekListesi();
            sEdilecek.MdiParent = this;
            sEdilecek.Show();
        }
        public static SiparişEdilenListesi sEdilen;
        private void siparişEdilenListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            sEdilen = new SiparişEdilenListesi();
            sEdilen.MdiParent = this;
            sEdilen.Show();
        }
        public static BorçluEkle borcluEkle;
        private void borçluEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            borcluEkle = new BorçluEkle();
            borcluEkle.MdiParent = this;
            borcluEkle.Show();
        }
        public static BorçluListesi borcluListesi; 
        private void borçluListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            borcluListesi = new BorçluListesi();
            borcluListesi.MdiParent = this;
            borcluListesi.Show();
        }
        public static BorçEkle borcEkle;
        private void borçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            borcEkle = new BorçEkle();
            borcEkle.MdiParent = this;
            borcEkle.Show();
        }
        public static BorçListesi borcListesi;
        private void borçListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            borcListesi = new BorçListesi();
            borcListesi.MdiParent = this;
            borcListesi.Show();
        }

        private void alınmışMalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Rapor_AlınmışMal R_Alınmıs = new Rapor_AlınmışMal();
            R_Alınmıs.ShowDialog();*/
        }

        private void satılmışMalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Rapor_SatılmışMal R_Satılmıs = new Rapor_SatılmışMal();
            R_Satılmıs.ShowDialog();*/
        }

        private void stokBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Rapor_StokBilgisi R_StokB = new Rapor_StokBilgisi();
            R_StokB.ShowDialog();*/
        }

        private void azalanÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Rapor_AzalanUrun R_Azalan = new Rapor_AzalanUrun();
            R_Azalan.ShowDialog();*/
        }
        public static SiparisListesine_Ekle SListesine_ekle;
        private void siparişListesineEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            SListesine_ekle = new SiparisListesine_Ekle();
            SListesine_ekle.MdiParent = this;
            SListesine_ekle.Show();
        }

        private void uygulamadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}