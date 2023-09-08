using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thuc_hanh_1
{
    internal class Banglop
    {
        private string malop;
        private string tenlop;
        public Banglop() { }
        public Banglop(string malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
        //connect database
        SqlConnection conn = new SqlConnection("Data Source=NGUYENHUYCUONG;Initial Catalog=QLSV;Integrated Security=True");
        public DataTable Get()
        {
            conn.Open();
            string sql = "select * from lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            DataColumn Malop = new DataColumn("Malop");
            dt.Columns.Add(Malop);
            DataColumn Tenlop = new DataColumn("Tenlop");
            dt.Columns.Add(Tenlop);
            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["Malop"] = read[0].ToString();
                row["Tenlop"] = read[1].ToString();
                dt.Rows.Add(row);
            }
            conn.Close();
            return dt;
        }
        public void Insert(Banglop ob)
        {
            string sql = "Insert into lop values('" + ob.malop + "',N'" + ob.tenlop + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(Banglop ob)
        {
            string sql = "update lop set Tenlop='" + ob.tenlop + "'" + "where Malop='" + ob.malop + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Banglop ob)
        {
            string sql = "delete from Lop where Malop='" + ob.malop + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}