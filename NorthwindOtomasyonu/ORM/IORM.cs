using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public interface IORM<T>
    {
        DataTable Listele();
        bool Ekle(T entity,Hashtable parameters);
        bool Guncelle(T entity,Hashtable parameters);

        bool Sil(Hashtable parameter);
    }
}
