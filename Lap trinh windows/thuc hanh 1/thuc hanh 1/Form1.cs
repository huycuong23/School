using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using thuc_hanh_1.thuc_hanh_1;

namespace thuc_hanh_1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, EventArgs e)
        {
            Banglop ob = new Banglop();
            dataGridView1.DataSource = ob.Get();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Banglop ob = new Banglop(TxtMalop.Text, TxtTenlop.Text);
            ob.Update(ob);
            ob.Get();
        }

        private void delete_Click(object sender, EventArgs e)
        {
                Banglop ob = new Banglop(TxtMalop.Text, TxtTenlop.Text);
                ob.Delete(ob);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Banglop ob = new Banglop(TxtMalop.Text, TxtTenlop.Text);
            ob.Insert(ob);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            dataGridView1.DataSource = sv.Get();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(TxtMalop.Text, TxtTenlop.Text);
            sv.Insert(sv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(TxtMalop.Text, TxtTenlop.Text);
            sv.Update(sv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(TxtMalop.Text, TxtTenlop.Text);
            sv.Delete(sv);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
