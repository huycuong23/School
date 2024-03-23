using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        SqlConnection sqlCnn = new SqlConnection();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sqlstr = "select * from tbl_dausach";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCnn = new SqlConnection("Data Source=NGUYENHUYCUONG;Initial Catalog=ShoppingOnline1;Integrated Security=True");
 //mo ket noi
            try
            {
                sqlCnn.Open();
                //khoi tao doi tuong dataadapter
                SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlstr,
               sqlCnn);
                //thuc thi
                sqlAdap.Fill(dt);
                //kt ket qua tra ve
                if (dt.Rows.Count > 0)
                {
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                { lblthongbao.Text = "Khong Co Du Lieu"; }
            }
            catch (Exception ex)
            { lblthongbao.Text = "Loi" + ex.Message; }
            finally
            { sqlCnn.Close(); sqlda.Dispose(); dt.Dispose(); }
        }
    }
}