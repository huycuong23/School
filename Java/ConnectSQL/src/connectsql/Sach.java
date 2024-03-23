/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package connectsql;

import java.util.Scanner;

/**
 *
 * @author cacbu
 */
public class Sach {

    private String MaSach, TenSach, LoaiSach;
    private int SoLuong, DonGia;

    public String getMaSach() {
        return MaSach;
    }

    public String getTenSach() {
        return TenSach;
    }

    public Sach(String MaSach, String TenSach, String LoaiSach, int SoLuong, int DonGia) {
        this.MaSach = MaSach;
        this.TenSach = TenSach;
        this.LoaiSach = LoaiSach;
        this.SoLuong = SoLuong;
        this.DonGia = DonGia;
    }

    public Sach() {

    }

    public String getLoaiSach() {
        return LoaiSach;
    }

    public int getSoLuong() {
        return SoLuong;
    }

    public int getDonGia() {
        return DonGia;
    }

    public void setMaSach(String MaSach) {
        this.MaSach = MaSach;
    }

    public void setTenSach(String TenSach) {
        this.TenSach = TenSach;
    }

    public void setLoaiSach(String LoaiSach) {
        this.LoaiSach = LoaiSach;
    }

    public void setSoLuong(int SoLuong) {
        this.SoLuong = SoLuong;
    }

    public void setDonGia(int DonGia) {
        this.DonGia = DonGia;
    }

    public void nhapThongTin() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Nhập mã sách: ");
        MaSach = scanner.nextLine();

        System.out.println("Nhập tên sách: ");
        TenSach = scanner.nextLine();

        System.out.println("Nhập loại sách: ");
        LoaiSach = scanner.nextLine();

        System.out.println("Nhập số lượng: ");
        SoLuong = scanner.nextInt();

        System.out.println("Nhập đơn giá: ");
        DonGia = scanner.nextInt();
    }

    public void xuatThongTin() {
        System.out.println("Mã sách: " + MaSach);
        System.out.println("Tên sách: " + TenSach);
        System.out.println("Loại sách: " + LoaiSach);
        System.out.println("Số lượng: " + SoLuong);
        System.out.println("Đơn giá: " + DonGia);
    }

    public static void main(String[] args) {
        Scanner sa = new Scanner(System.in);
        int dem = 0;
        int tongsach = 0;
        System.out.println("nhap so luong sach :");
        int soluongsach = sa.nextInt();
        Sach[] danhsach = new Sach[soluongsach];
        for (int i = 0; i < soluongsach; i++) {
            System.out.println("Nhập thông tin sách thứ " + (i + 1) + ":");
            Sach sach = new Sach();
            sach.nhapThongTin();
            danhsach[i] = sach;
        }
        System.out.println("Các sách có loại 'lap trinh':");
        for (Sach sach : danhsach) {
            if (sach.LoaiSach.equalsIgnoreCase("lap trinh")) {
                sach.xuatThongTin();
                dem=dem + soluongsach;
                System.out.println("-------------------------");
            }
        }
        System.out.println("so luong sach lap trinh :" + dem);
        for (Sach sach : danhsach) {

            sach.xuatThongTin();
            tongsach += sach.SoLuong;
            System.out.println("-------------------------");

        }
        System.out.println("tong tat ca cac loai sach : " + tongsach);
    }
}
