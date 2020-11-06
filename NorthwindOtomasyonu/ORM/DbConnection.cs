using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class DbConnection
    {
        private SqlConnection conn;

        //region Contructor
        public DbConnection()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalBaglanti"].ConnectionString);
        }
        public DbConnection(string conText)
        {

            conn = new SqlConnection(conText);
        }
        //endregion

        //region OpenConnection
        private void OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }

            catch
            {
                throw new Exception("Veritabani baglantisi kurulamadi");
            }
        }
        //endregion

        //region CloseConnection
        private void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        //endregion

        //region NonQuery parametresiz
        public int NonQuerySP(string spName)
        {
            try
            {
                int rowCount = 0;
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                OpenConnection();
                rowCount = cmd.ExecuteNonQuery();
                return rowCount;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP Geri Donussuz Sorgu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion
        //region NonQuery
        public int NonQuerySP(string spName, Hashtable parameters)
        {
            try
            {
                int rowCount = 0;
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        cmd.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);
                    }
                }

                OpenConnection();
                rowCount = cmd.ExecuteNonQuery();
                return rowCount;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP Geri Donussuz Sorgu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion

        //region NonQuery parametresiz without SP
        public int NonQuery(string cmdText)
        {
            try
            {
                int rowCount = 0;
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                OpenConnection();
                rowCount = cmd.ExecuteNonQuery();
                return rowCount;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP Geri Donussuz Sorgu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion

        //region NonQuery without SP
        public int NonQuery(string cmdText, Hashtable parameters)
        {
            try
            {
                int rowCount = 0;
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        cmd.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);
                    }
                }

                OpenConnection();
                rowCount = cmd.ExecuteNonQuery();
                return rowCount;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP Geri Donussuz Sorgu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion

        //region ReturnDataSet parametresiz without SP
        public DataTable ReturnDataTable(string cmdTxt)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdTxt, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //endregion
        //region ReturnDataSet parametresiz with SP
        public DataTable ReturnDataTableSP(string spName)
        {
            SqlDataAdapter da = new SqlDataAdapter(spName, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //endregion
        //region ReturnDataSet without SP
        public DataTable ReturnDataTable(string cmdText, Hashtable parameters)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
                da.SelectCommand.CommandType = CommandType.Text;
                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        da.SelectCommand.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);

                    }
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP ReturnDataSet metodu");
            }
        }
        //endregion
        //region ReturnDataSet with SP
        public DataTable ReturnDataTableSP(string spName, Hashtable parameters)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(spName, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        da.SelectCommand.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);
                    }
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP ReturnDataSet metodu");
            }
        }
        //endregion
        //region ReturnString without SP
        public string ReturnString(string cmdTxt)
        {
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            OpenConnection();
            object obj = cmd.ExecuteScalar();
            CloseConnection();
            if (obj == null)
                return "";
            return obj.ToString();
        }
        //endregion

        //region ReturnString with SP
        public string ReturnStringSP(string spName)
        {
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OpenConnection();
            object obj = cmd.ExecuteScalar();
            CloseConnection();
            if (obj == null)
                return "";
            return obj.ToString();
        }
        //endregion


        //region ReturnString without SP
        public string ReturnString(string cmdTxt, Hashtable parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.CommandType = CommandType.Text;
                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        cmd.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);
                    }
                }
                OpenConnection();
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                    return null;
                return obj.ToString();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP ReturnString Metodu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion
        //region ReturnString with SP
        public string ReturnStringSP(string spName, Hashtable parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null && parameters.Count != 0)
                {
                    IDictionaryEnumerator ienum = parameters.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        cmd.Parameters.AddWithValue(ienum.Key.ToString(), ienum.Value);
                    }
                }
                OpenConnection();
                object obj = cmd.ExecuteScalar();
                if (obj == null)
                    return null;
                return obj.ToString();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " SP ReturnString Metodu");
            }

            finally
            {
                CloseConnection();
            }
        }
        //endregion
    }
}
