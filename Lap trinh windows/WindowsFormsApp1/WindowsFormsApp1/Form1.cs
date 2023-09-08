using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Lop_BUS lop = new Lop_BUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Get_Click(object sender, EventArgs e)
        {
             dataGridView.DataSource = lop.Load_BUS();
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
           Malop.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
           Tenlop.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Lop Lop = new Lop(Malop.Text, Tenlop.Text);
            lop.Update_BUS(Lop);
            Get_Click(sender, e);
            Malop.Clear();
            Tenlop.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Lop Lop = new Lop(Malop.Text, Tenlop.Text);
            lop.Delete_BUS(Lop);
            Get_Click(sender, e);
            Malop.Clear();
            Tenlop.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(Malop.Text.Trim() != "" && Tenlop.Text.Trim() != "")
            {
                Lop Lop = new Lop(Malop.Text, Tenlop.Text);
                lop.Insert_BUS(Lop);
                Get_Click(sender, e);
                Malop.Clear();
                Tenlop.Clear();
            }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void Malop_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
