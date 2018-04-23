using StockDevelopment.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDevelopment.WinForm.UI.FORMS
{
    public partial class StokBilgi : Form
    {
        public StokBilgi()
        {
            InitializeComponent();
        }

        public DataTable SELECT()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("PRC_STOK_BILGISI"), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        private void StokBilgi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SELECT();
        }
    }
}
