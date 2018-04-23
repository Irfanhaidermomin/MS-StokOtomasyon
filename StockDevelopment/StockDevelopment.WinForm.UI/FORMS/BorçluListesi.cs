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
    public partial class BorçluListesi : Form
    {
        public BorçluListesi()
        {
            InitializeComponent();
        }

        BorcluORM bOrm = new BorcluORM();

        private void BorçluListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bOrm.SELECT();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BorçluEkle gonder = new BorçluEkle();

            gonder.adiSoyadi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            gonder.borcu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gonder.odemeTar = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            gonder.telNo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gonder.adres = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            this.Close();
            gonder.ShowDialog();
        }
    }
}
