using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM
{
    public class Tools
    {
        //Singleton Pattern

        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }
                return baglanti;
            }
        }
        public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                int etk = cmd.ExecuteNonQuery();

                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }
        public static void ParametreOlustur<T>(SqlCommand cmd, KomutTip kt, T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;

                #region MyRegion
                /*if (name.ToLower() == "ıd" || name.ToLower() == "id" && kt == KomutTip.INSERT)
                {
                    continue;
                }*/
                
                #endregion

                if (kt == KomutTip.DELETE && (name == "ID" || name == "TC" || name == "URUNKODU"))//  else if (kt == KomutTip.DELETE && (name.ToLower() != "tc"))
                {
                    object value = pi.GetValue(ent);

                    cmd.Parameters.AddWithValue("@" + name, value);
                }
                else if (kt == KomutTip.INSERT && name != "ID")
                {
                    object value = pi.GetValue(ent);

                    cmd.Parameters.AddWithValue("@" + name, value);
                }
                else if (kt == KomutTip.UPDATE && name != "BORCTARIHI" && name != "KAYITTARIHI")
                {
                    object value = pi.GetValue(ent);

                    cmd.Parameters.AddWithValue("@" + name, value);
                }
                else
                {
                    continue;
                }
            }
        }
        #region MyRegion
        /*public static void ParametreOlustur_DELETE_URUN<T>(SqlCommand cmd, KomutTip kt, T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;

                if (kt == KomutTip.DELETE && (name.ToLower() != "tc"))   // else if (kt == KomutTip.DELETE && (name.ToLower() != "ıd" || name.ToLower() != "id"))
                {
                    continue;
                }
                object value = pi.GetValue(ent);

                cmd.Parameters.AddWithValue("@" + name, value);
            }
        }
        public static void ParametreOlustur_DELETE_BORC<T>(SqlCommand cmd, KomutTip kt, T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;

                if (kt == KomutTip.DELETE && (name.ToLower() != "borcıd"))   // else if (kt == KomutTip.DELETE && (name.ToLower() != "ıd" || name.ToLower() != "id"))
                {
                    continue;
                }
                object value = pi.GetValue(ent);

                cmd.Parameters.AddWithValue("@" + name, value);
            }
        }*/
        
        #endregion
    }
}
