using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class clsKetNoi
    {
        SqlConnection connect = new SqlConnection();
        public clsKetNoi()
        {
            //string conString = ConfigurationManager.ConnectionStrings["DBQLSV"].ToString();
            string conString = "server=(local)\\SQLEXPRESS;database=QLHS;integrated security=true";
            connect = new SqlConnection(conString);
            if (connect.State == ConnectionState.Closed)
            {
            } connect.Open();
        }
        public DataTable LoadData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public int Update(string sql, string[]name,object[]value,int n)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            for (int i = 0; i < n; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SinhMa(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            int x = cmd.ExecuteNonQuery();
            return x;
        }
    }
}
