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
    public partial class SiparişEdilenListesi : Form
    {
        public SiparişEdilenListesi()
        {
            InitializeComponent();
        }

        SiparisEdilenORM edilenOrm = new SiparisEdilenORM();

        private void SiparişEdilenListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = edilenOrm.SELECT();
        }
    }
}
