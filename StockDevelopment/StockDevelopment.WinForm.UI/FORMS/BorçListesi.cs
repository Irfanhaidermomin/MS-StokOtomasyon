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
    public partial class BorçListesi : Form
    {
        public BorçListesi()
        {
            InitializeComponent();
        }

        BorcORM bOrm = new BorcORM();

        private void BorçListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bOrm.SELECT();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BorçEkle gonder = new BorçEkle();

            gonder.adiSoyadi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            gonder.borcumuz = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gonder.odemeTar = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            gonder.telNo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gonder.adres = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            this.Close();
            gonder.ShowDialog();
        }
    }
}
