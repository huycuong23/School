using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Reporting;

namespace QuanLiTienNuoc
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
          

        }
        public SqlConnection con = new SqlConnection("Data Source=NGUYENHUYCUONG;Initial Catalog=QLTN;Integrated Security=True");

        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public DataTable LayDL(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LayDL("select * from giadinh");
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "makhach";
            comboBox1.DisplayMember = "makhach";
            this.reportViewer1.RefreshReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "Select * from giadinh where makhach='" + comboBox1.Text + "'";
            DataTable dt = new DataTable();
            dt = LayDL(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Phải chuột vào tên Report=> copy=> dán đường dẫn vào
            reportViewer1.LocalReport.ReportPath = "D:\\Workspace\\School\\Lap trinh windows\\QuanLiTienNuoc\\QuanLiTienNuoc\\In_QLTN.rdlc";
            if (dt.Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "GiaDinh";
                rds.Value = dt;
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Khong co du lieu");
        }

    }
}
