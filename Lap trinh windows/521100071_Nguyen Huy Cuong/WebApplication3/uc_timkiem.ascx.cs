using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class uc_timkiem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btntim_Click(object sender, EventArgs e)
        {
            Session["tensach"] = txttensach.Text;
            Session["tacgia"] = txttentacgia.Text;
            Response.Redirect("~/kqtimtimkiem.aspx");
        }
    }
}