using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_CSDL_Form.ServiceReference1;

namespace WS_CSDL_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            BangLop lop = new BangLop();
            lop.Malop = textBox1.Text;
            lop.Tenlop = textBox2.Text;
            string msg = ob.Insert_Lop(lop);
            MessageBox.Show(msg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<BangLop> lops = new List<BangLop>();
            ICSDLServiceClient ob = new ICSDLServiceClient();
            lops = ob.GetAll().ToList();
            // Chuyển sang datagridview
            dataGridView1.DataSource = lops;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            BangLop lop = new BangLop();
            lop.Malop= textBox1.Text;
            lop.Tenlop = textBox2.Text;
            ob.Update_Lop(lop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            BangLop lop = new BangLop();
            lop.Malop = textBox1.Text;
            lop.Tenlop = textBox2.Text;
            ob.Delete_Lop(lop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            Bangmon mon = new Bangmon();
            mon.mamon = textBox1.Text;
            mon.temon = textBox2.Text;
            string msg = ob.Insert_Mon(mon);
            MessageBox.Show(msg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Bangmon> mons = new List<Bangmon>();
            ICSDLServiceClient ob = new ICSDLServiceClient();
            mons = ob.Get_Mon().ToList();
            // Chuyển sang datagridview
            dataGridView1.DataSource = mons;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            Bangmon mon = new Bangmon();
            mon.mamon = textBox1.Text;
            mon.temon = textBox2.Text;
            ob.Update_Mon(mon);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ICSDLServiceClient ob = new ICSDLServiceClient();
            Bangmon mon = new Bangmon();
            mon.mamon = textBox1.Text;
            mon.temon = textBox2.Text;
            ob.Delete_Mon(mon);
        }
    }
}
