using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Security.Policy;
using OfficeOpenXml;
using System.Windows.Media;
using System.IO;

namespace QuanLiTienNuoc
{
    public partial class Form1 : Form
    {
        Class1 khach = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            khachhang ob = new khachhang(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            khach.Update_Bus(ob);
            button1_Click(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khach.Load_Bus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            khachhang ob = new khachhang(textBox1.Text , textBox2.Text , textBox3.Text, textBox4.Text);
            khach.Insert_Bus(ob);
            button1_Click(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            khachhang ob = new khachhang(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            khach.Delete_Bus(ob);
            button1_Click(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Nguyen Huy Cuong";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Danh sách Khach hang";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh_sach_KH");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Danh_sach_kh";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Ma khach hang",
                                                "Ten khach hang",
                                                "Dia chi",
                                                "So dien thoai",
                                                "Ngay sinh",
                                                "Doanh so",
                                                "NGGN"
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Danh sách khach hang";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //gán giá trị
                        cell.Value = item;
                        colIndex++;
                    }

                    // Khai báo danh sách sinh viên
                    List<khachhang> userList = new List<khachhang>();
                    // lấy ra danh sách chuyển sang List từ gridview
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        khachhang ob = new khachhang();
                        ob.makhach = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ob.tenkhach = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ob.diachi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ob.sodienthoai = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        userList.Add(ob);
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in userList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.makhach;
                        ws.Cells[rowIndex, colIndex++].Value = item.tenkhach;
                        ws.Cells[rowIndex, colIndex++].Value = item.diachi;
                        ws.Cells[rowIndex, colIndex++].Value = item.sodienthoai;
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }

        }
    }
}
