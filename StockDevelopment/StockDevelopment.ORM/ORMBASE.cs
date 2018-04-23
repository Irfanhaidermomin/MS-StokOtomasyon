using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM
{
    public class ORMBASE<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                // typeof : Tipi billi olmayan (generic bir) elemanın tipini belirlemeyi sağlar.

                return typeof(T).Name;

                // Name özelliği T tipinin (sınıfının) adını verir.
            }
        }

        public DataTable SELECT()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("PRC_{0}_SELECT", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }


        public bool INSERT(T ENTİTY)
        {
            SqlCommand cmd = new SqlCommand(string.Format("PRC_{0}_INSERT", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            // GetProperties : T elemanı içerisindeki property'ler bir dizi olarak dödüren metotdur.

            Tools.ParametreOlustur<T>(cmd, KomutTip.INSERT, ENTİTY);

            return Tools.Exec(cmd);
        }

        public bool DELETE(T ENTİTY)
        {
            SqlCommand cmd = new SqlCommand(string.Format("PRC_{0}_DELETE", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.DELETE, ENTİTY);

            return Tools.Exec(cmd);
        }

        public bool UPDATE(T ENTİTY)
        {
            SqlCommand cmd = new SqlCommand(string.Format("PRC_{0}_UPDATE", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.UPDATE, ENTİTY);

            return Tools.Exec(cmd);
        }



       /* public bool DELETE_URUN(T ENTİTY)
        {
            SqlCommand cmd = new SqlCommand(string.Format("PRC_{0}_DELETE", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur_DELETE_URUN<T>(cmd, KomutTip.DELETE, ENTİTY);

            return Tools.Exec(cmd);
        }

        public bool DELETE_BORC(T ENTİTY)
        {
            SqlCommand cmd = new SqlCommand(string.Format("PRC_{0}_DELETE", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur_DELETE_BORC<T>(cmd, KomutTip.DELETE, ENTİTY);

            return Tools.Exec(cmd);
        }*/
    }
}
