using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public class connect
    {
        SqlConnection conn = new SqlConnection("Data Source=PC-MINHIUS\\HAMINHHIEU;Initial Catalog=QLTN;Integrated Security=True");
        public DataTable Load_KH(string sql)
        {
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Excute(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
