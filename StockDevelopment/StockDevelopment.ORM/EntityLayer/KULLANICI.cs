using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM.EntityLayer
{
    public class KULLANICI
    {
        public string TC { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string KULLANICIADI { get; set; }
        public string SIFRE { get; set; }
        public string YETKISI { get; set; }
        public string GIZLIYANIT { get; set; }
        public string EMAIL { get; set; }
        public string TELNO { get; set; }
        public DateTime KAYITTARIHI { get; set; }
        public string ADRES { get; set; }
    }
}
