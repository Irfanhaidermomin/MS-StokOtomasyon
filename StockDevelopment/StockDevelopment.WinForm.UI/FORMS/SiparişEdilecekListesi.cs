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
    public partial class SiparişEdilecekListesi : Form
    {
        public SiparişEdilecekListesi()
        {
            InitializeComponent();
        }

        SiparisEdilecekORM edilecekOrm = new SiparisEdilecekORM();

        private void SiparişEdilecekListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = edilecekOrm.SELECT();
        }
    }
}
