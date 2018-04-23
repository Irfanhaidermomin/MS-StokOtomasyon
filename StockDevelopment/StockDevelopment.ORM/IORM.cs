using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDevelopment.ORM
{
    // IORM : İnterfaceORM anlamında.
    //Bu alan OtelOtomayonu.ORM içinde interface açılmıştır.

    public interface IORM<T> where T : class   // T class tipinde verilmesi şarttır kodu !!
    {
        DataTable SELECT();
        bool INSERT(T ENTİTY);
        bool UPDATE(T ENTİTY);
        bool DELETE(T ENTİTY);
       // bool DELETE_URUN(T ENTİTY);
       // bool DELETE_BORC(T ENTİTY);
    }
}
