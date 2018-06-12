using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiWinfrom
{
    public class Cl_Database : IDisposable
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;
        string connectionString = "server=TAKEDA_PHAM; database=ThiASP; integrated security= true";
        public Cl_Database()
        {
            cnn = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
            }
            if (cmd != null)
            {
                cmd.Dispose();
            }
            if (cnn != null)
            {
                da.Dispose();
            }
        }
        public DataTable GetDataTable(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandTimeout = 600;
                cmd.CommandType = type;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex) 
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        public bool ExcuteNoQuery(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            bool result = false;
            try
            {
                int i; 
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandTimeout = 600;
                cmd.CommandType = type;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return result;
        }
    }
}
