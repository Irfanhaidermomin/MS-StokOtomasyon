using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM.EntityLayer
{
    public class BORCLU
    {
        public int ID { get; set; }
        public string ADISOYADI { get; set; }
        public string BORCU { get; set; }
        public DateTime BORCTARIHI { get; set; }
        public DateTime ODEMETARIHI { get; set; }
        public string TELNO { get; set; }
        public string ADRES { get; set; }
    }
}
