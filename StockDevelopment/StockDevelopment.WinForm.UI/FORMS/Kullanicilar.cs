using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockDevelopment.ORM.FacadeLayer;
using StockDevelopment.ORM.EntityLayer;

namespace StockDevelopment.WinForm.UI.FORMS
{
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }

        KullanıcıORM kOrm = new KullanıcıORM();

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kOrm.SELECT();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KullaniciEkle Gonder = new KullaniciEkle();

            Gonder.tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Gonder.adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Gonder.soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Gonder.kullanici_adi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Gonder.sifre = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Gonder.yetkisi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Gonder.gizli_yanit = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Gonder.email = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Gonder.telefon = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            Gonder.adres = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            this.Close();
            Gonder.ShowDialog();
        }
    }
}
