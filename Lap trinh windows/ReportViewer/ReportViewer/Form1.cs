using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportViewer
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
