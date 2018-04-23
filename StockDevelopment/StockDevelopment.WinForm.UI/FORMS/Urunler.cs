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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        UrunlerORM uOrm = new UrunlerORM();

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uOrm.SELECT();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UrunEkle gonder = new UrunEkle();

            gonder.urunKodu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gonder.urunAdı = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            gonder.urunMiktari = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gonder.urunCinsi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            gonder.alısFiyat = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gonder.satişFiyat = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            gonder.ShowDialog();
        }
    }
}
