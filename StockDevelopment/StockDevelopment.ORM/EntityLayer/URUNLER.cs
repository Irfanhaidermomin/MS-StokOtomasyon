using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM.EntityLayer
{
    public class URUNLER
    {
        public string URUNKODU { get; set; }
        public string URUNADI { get; set; }
        public string URUNMIKTARI { get; set; }
        public string URUNCINSI { get; set; }
        public DateTime ALISTARIHI { get; set; }
        public string ALISFIYAT { get; set; }
        public string SATISFIYAT { get; set; }
    }
}
