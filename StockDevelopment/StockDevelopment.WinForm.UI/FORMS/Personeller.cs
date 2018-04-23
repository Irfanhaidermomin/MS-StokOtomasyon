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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        PersonelORM pOrm = new PersonelORM();

        private void Personeller_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pOrm.SELECT();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PersonelEkle gonder = new PersonelEkle();

            gonder.tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gonder.adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            gonder.soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gonder.maas = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            gonder.telno = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            gonder.baslamaTar = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gonder.medeniHal = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            gonder.adres = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            this.Close();
            gonder.ShowDialog();
        }
    }
}
