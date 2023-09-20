using System.Data;
using System.Data.SqlClient;


namespace Excel
{
    public class SinhVien
    {
        public string Masv { get; set; }
        public string Hoten { get; set; }


        SqlConnection con = new SqlConnection("Data Source=NguyenHuyCuong;Initial Catalog=QLSV;Integrated Security=True");
        //view
        public DataTable view(string Txtlop)
        {
            string sql = "select * from sinhvien where Lop ='" + Txtlop + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable("Lop");
            // tao 2 cot
            DataColumn Malop = new DataColumn("Masinhvien");
            dt.Columns.Add(Malop);
            DataColumn Tenlop = new DataColumn("Tensinhvien");
            dt.Columns.Add(Tenlop);
            while (read.Read())
            {
                //tao dong va gan du lieu
                DataRow row = dt.NewRow();
                row["Masinhvien"] = read[0].ToString();
                row["Tensinhvien"] = read[1].ToString();
                dt.Rows.Add(row);
            }
            con.Close();
            return dt;
        }
    }




}
