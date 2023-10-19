using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media;
using BUS;
using DTO;
using OfficeOpenXml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Lop_BUS Sp = new Lop_BUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Sp.Load_BUS();
        }

        private void Get_Click(object sender, EventArgs e)
        {
             dataGridView.DataSource = Sp.Load_BUS();
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
           TxtMasp.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
           TxtTensp.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
           TxtDvt.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
           TxtGia.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Sanpham sp = new Sanpham(TxtMasp.Text, TxtTensp.Text, TxtDvt.Text, TxtGia.Text);
            Sp.Update_BUS(sp);
            Get_Click(sender, e);
            TxtGia.Clear();
            TxtMasp.Clear();
            TxtTensp.Clear();
            TxtDvt.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Sanpham sp = new Sanpham(TxtMasp.Text, TxtTensp.Text, TxtDvt.Text, TxtGia.Text);
            Sp.Delete_BUS(sp);
            Get_Click(sender, e);
            TxtGia.Clear();
            TxtMasp.Clear();
            TxtTensp.Clear();
            TxtDvt.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(TxtMasp.Text.Trim() != "" && TxtTensp.Text.Trim() != "")
            {
                Sanpham sp = new Sanpham(TxtMasp.Text, TxtTensp.Text, TxtDvt.Text, TxtGia.Text);
                Sp.Insert_BUS(sp);
                Get_Click(sender, e);
                TxtGia.Clear();
                TxtMasp.Clear();
                TxtTensp.Clear();
                TxtDvt.Clear();
            }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(System.Drawing.Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void Malop_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                    p.Workbook.Properties.Author = "Nguyễn Huy Cương";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Danh sách sản phẩm:";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh_sach_SP");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Danh_sach_Lop_";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Mã sản phẩm",
                                                "Tên Spham",
                                                "Don vi tinh"
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Danh sách sản phẩm đã bán trong tháng 11";
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
                    List<Sanpham> userList = new List<Sanpham>();
                    // lấy ra danh sách chuyển sang List từ gridview
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        Sanpham ob = new Sanpham();
                        ob.Masp = dataGridView.Rows[i].Cells[0].Value.ToString();
                        ob.Tensp = dataGridView.Rows[i].Cells[1].Value.ToString();
                        ob.DVT = dataGridView.Rows[i].Cells[2].Value.ToString();
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
                        ws.Cells[rowIndex, colIndex++].Value = item.Masp;
                        ws.Cells[rowIndex, colIndex++].Value = item.Tensp;
                        ws.Cells[rowIndex, colIndex++].Value = item.DVT;
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = Sp.Load_BUS();
        }
    }
    }
