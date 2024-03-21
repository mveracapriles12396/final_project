using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Database
{
    internal class DatabaseAccess
    {
        private string connectionString;
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        public DatabaseAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int insertData(string query)
        {
            try
            {
                conn.ConnectionString = connectionString;
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public int updateData(string query)
        {
            try
            {
                conn.ConnectionString = connectionString;
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                return 1; 
            }
            catch (Exception ex)
            {
                return -1; 
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public int deleteData(string query)
        {
            try
            {
                conn.ConnectionString = connectionString;
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                return -1; 
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public DataTable SelectData(string query)
        {
            DataTable dt = new DataTable(); 
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt); 
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return dt; 
        }

    }
}
