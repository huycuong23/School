using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuc_hanh_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;

    namespace thuc_hanh_1
    {
        internal class Sinhvien
        {
            private string Masinhvien;
            private string Tensinhvien;
            public Sinhvien() { }
            public Sinhvien(string Masinhvien, string Tensinhvien)
            {
                this.Masinhvien = Masinhvien;
                this.Tensinhvien = Tensinhvien;
            }
            //connect database
            SqlConnection conn = new SqlConnection("Data Source=NGUYENHUYCUONG;Initial Catalog=QLSV;Integrated Security=True");
            public DataTable Get()
            {
                conn.Open();
                string sql = "select * from sinhvien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                DataColumn Masinhvien = new DataColumn("Masinhvien");
                dt.Columns.Add(Masinhvien);
                DataColumn Tensinhvien = new DataColumn("Tensinhvien");
                dt.Columns.Add(Tensinhvien);
                while (read.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Masinhvien"] = read[0].ToString();
                    row["Tensinhvien"] = read[1].ToString();
                    dt.Rows.Add(row);
                }
                conn.Close();
                return dt;
            }
            public void Insert(Sinhvien ob)
            {
                string sql = "Insert into sinhvien values('" + ob.Masinhvien + "',N'" + ob.Tensinhvien + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void Update(Sinhvien ob)
            {
                string sql = "update sinhvien set Tensinhvien='" + ob.Tensinhvien + "'" + "where Masinhvien='" + ob.Masinhvien + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void Delete(Sinhvien ob)
            {
                string sql = "delete from sinhvien where Masinhvien='" + ob.Masinhvien + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
