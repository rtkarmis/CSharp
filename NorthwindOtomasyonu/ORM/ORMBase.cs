using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ORMBase<TT>:IORM<TT>
    {
        public static Type Tip
        {
            get { return typeof(TT); }
        }
        
        

        DbConnection dbConnection = new DbConnection();
        public DataTable Listele()
        {
            string spName = string.Format("SP_{0}_Select", Tip.Name);
            DataTable dt = dbConnection.ReturnDataTableSP(spName);
            return dt;
        }


        public bool Ekle(TT entity,Hashtable parameters)
        {
            bool result = false;
            string spName = string.Format("SP_{0}_Insert", Tip.Name);
            int rowCount = dbConnection.NonQuerySP(spName, parameters);
            if (rowCount > 0)
                result = true;
            return result;

        }

        public bool Guncelle(TT entity,Hashtable parameters)
        {
            bool result = false;
            string spName = string.Format("SP_{0}_Update", Tip.Name);
            int rowCount = dbConnection.NonQuerySP(spName,parameters);
            if (rowCount > 0)
                result = true;
            return result;
        }

        public bool Sil(Hashtable parameter)
        {
            bool result = false;
            string spName = string.Format("SP_{0}_Delete", Tip.Name);
            int rowCount = dbConnection.NonQuerySP(spName, parameter);

            if (rowCount > 0)
                result = true;
            return result;
        }

        public Hashtable ORMParameters(TT entity)
        {
            PropertyInfo[] property = Tip.GetProperties();
            Hashtable hashtable = new Hashtable();

            foreach (PropertyInfo info in property)
            {
                string key = info.Name;

                object value = info.GetValue(entity);

                
                if (key != "PrimaryColumn")
                {
                    hashtable.Add(key, value);
                }
            }
            return hashtable;
        }

        public Hashtable ORMOneParameter(int id)
        {
            TT entity = Activator.CreateInstance<TT>();
            PropertyInfo property = Tip.GetProperty("PrimaryColumn");
            Hashtable hashtable = new Hashtable();
            string key = property.GetValue(entity).ToString();
            hashtable.Add(key,id);
            return hashtable;
        }
    }
}
