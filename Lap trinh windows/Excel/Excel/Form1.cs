using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien();
            dataGridView1.DataSource = ob.view("select * from sinhvien where Lop ='" + Txtlop.Text + "'");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2019 | *.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Duong dan bao cao khong hop le");
                return;
            }
            try
            {

                using (ExcelPackage p = new ExcelPackage())
                {
                    // dat ten cho ng tao file
                    p.Workbook.Properties.Author = "NguyenHuyCuong";
                    // dat tieu de cho file
                    p.Workbook.Properties.Title = "Bao cao thong ke";
                    // tao mot sheet de lam viec
                    p.Workbook.Worksheets.Add("Danh Sach Lop");
                    // lay sheet vua add de thao tac
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];
                    // dat ten cho sheet
                    ws.Name = "Danh sach lop" + Txtlop.Text;
                    // fronsize mac dinh cho ca sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mac dinh cho ca sheet
                    ws.Cells.Style.Font.Name = "Arial";
                    // tao danh sach cho cac column header
                    string[] arrColumnHeader =
                    {
                    "Ma so",
                    "Ho ten"
                };

                    var countColHeader = arrColumnHeader.Count();
                    // merge cac column lai tu cl 1  den cl header
                    // gan gia tri cho cell vua merge

                    ws.Cells[1, 1].Value = "thong ke thong tin";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in dam
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    int colIndex = 1;
                    int rowIndex = 2;
                    // tao cac haeader tu column header da tao tu ben tren
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        // gan gia tri
                        cell.Value = item;
                        colIndex++;
                    }
                    List<SinhVien> usertList = new List<SinhVien>();
                    // lay ra dnah sach chuyen sang list tu gridview
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SinhVien ob = new SinhVien();
                        ob.Masv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ob.Hoten = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        usertList.Add(ob);
                    }

                    // voi moi item trong danh sach se ghi tren 1 dong
                    foreach (var item in usertList)
                    {
                        // bat dau ghi tu cot 1 . Excel bat dau tu 1 khong phai tu 0
                        colIndex = 1;
                        // rowindex tuong ung tung dong du lieu
                        rowIndex++;
                        // gan gia tri cho tung cell
                        ws.Cells[rowIndex, colIndex++].Value = item.Masv;
                        ws.Cells[rowIndex, colIndex++].Value = item.Hoten;
                    }
                    // luu lai file
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuat excel thanh cong");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Xuat excel that bai");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien();
            dataGridView1.DataSource = ob.view("select sinhvien.Masinhvien, sinhvien.Tensinhvien, sinhvien.Lop, diem.diem from sinhvien inner join diem on sinhvien.Masinhvien = diem.Masinhvien where diem < 4 and Lop ='" + Txtlop.Text + "'");
        }
    }
}
