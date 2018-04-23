using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM.EntityLayer
{
    public class SIPARISEDILECEK
    {
        public int ID { get; set; }
        public string URUNADI { get; set; }
        public DateTime SIPARISTARIHI { get; set; }
        public string MIKTAR { get; set; }
    }
}
