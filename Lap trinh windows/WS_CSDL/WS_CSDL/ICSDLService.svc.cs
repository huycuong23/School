using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace WS_CSDL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ICSDLService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ICSDLService.svc or ICSDLService.svc.cs at the Solution Explorer and start debugging.
    public class ICSDLService : IICSDLService
    {

        SqlConnection con = new SqlConnection("Data Source=NguyenHuyCuong;Initial Catalog=QLSV;Integrated Security=True");
        public string Insert_Lop(BangLop lop)
        {
            string Message;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into lop values(@malop,@tenlop)", con);
            cmd.Parameters.AddWithValue("@malop", lop.Malop);
            cmd.Parameters.AddWithValue("@tenlop", lop.Tenlop);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = "Insert success";
            }
            else
            {
                Message = "Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
        public List<BangLop> GetAll()
        {
            List<BangLop> lops = new List<BangLop>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from lop", con);
            SqlDataReader doc = cmd.ExecuteReader();
            while (doc.Read())
            {
                BangLop ob = new BangLop();
                ob.Malop = doc[0].ToString();
                ob.Tenlop = doc[1].ToString();
                lops.Add(ob);

            }
            return lops;

        }
        public void Update_Lop (BangLop lop)
        {
           
            con.Open();
            String sql = "update Lop set Tenlop ='" + lop.Tenlop + "'" + "where Malop = '" + lop.Malop + "'";
            SqlCommand cmd = new SqlCommand(sql , con);
            cmd.ExecuteNonQuery();
            con.Close ();
            

        }

        public void Delete_Lop (BangLop lop)
        {
            con.Open();
            String sql = "Delete from Lop where Tenlop = '" +lop.Tenlop + "'";
            SqlCommand cmd = new SqlCommand (sql , con);
            cmd.ExecuteNonQuery ();
            con.Close ();
        }


        // Mon
        public string Insert_Mon(Bangmon mon)
        {
            string Message;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into mon values(@mamon,@tenmon)", con);
            cmd.Parameters.AddWithValue("@mamon", mon.mamon);
            cmd.Parameters.AddWithValue("@tenmon", mon.temon);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = "Insert success";
            }
            else
            {
                Message = "Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
        public List<Bangmon> Get_Mon()
        {
            List<Bangmon> mons = new List<Bangmon>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mon", con);
            SqlDataReader doc = cmd.ExecuteReader();
            while (doc.Read())
            {
                Bangmon ob = new Bangmon();
                ob.mamon = doc[0].ToString();
                ob.temon = doc[1].ToString();
                mons.Add(ob);

            }
            return mons;

        }
        public void Update_Mon(Bangmon mon)
        {

            con.Open();
            String sql = "update mon set tenmon ='" + mon.temon + "'" + "where mamon = '" + mon.mamon + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void Delete_Mon(Bangmon mon)
        {
            con.Open();
            String sql = "Delete from mon where Tenmon = '" + mon.temon + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
