/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package danhsachsv;

import java.io.*;

/**
 *
 * @author cacbu
 */
public class Danhsachsv {

    int masv;
    String hoten;
    int tuoi;
    float dtb;

    void nhap() throws IOException {
        BufferedReader buf = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Nhap vao ma sinh vien:");
        masv = Integer.parseInt(buf.readLine());
        System.out.println("Nhap ten sinh vien:");
        hoten = buf.readLine();
        System.out.println("Nhap vao tuoi:");
        tuoi = Integer.parseInt(buf.readLine());
        System.out.println("Nhap vao DTB:");
        dtb = Float.parseFloat(buf.readLine());
    }

    void xuat(int stt) {
        System.out.println(stt + "    " + masv + "             " + hoten + "      " + tuoi + "       " + dtb);
    }
}

class dssv {

    int n;
    Danhsachsv ds[];

    void nhapds() throws IOException {
        BufferedReader buf = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("***Nhap danh sach sinh vien***");
        System.out.println("Nhap so sinh vien");
        n = Integer.parseInt(buf.readLine());
        ds = new Danhsachsv[n];
        for (int i = 0; i < n; i++) {
            Danhsachsv x = new Danhsachsv();
            x.nhap();
            ds[i] = x;
        }
    }

    void xuatds() {
        System.out.println("***Danh sach sinh vien da nhap: ");
        System.out.println("stt  " + "Ma sinh vien" + "   " + "Ho ten" + "               " + "Tuoi" + "   " + "Diem trung binh");
        for (int i = 0; i < n; i++) {
            ds[i].xuat((i + 1));
        }
    }

    void tuoi25() {
        int t = 0;
        System.out.println("***Danh sach sinh vien co tuoi lon hon 25***");
                System.out.println("stt  " + "Ma sinh vien" + "   " + "Ho ten" + "               " + "Tuoi" + "   " + "Diem trung binh");

        for (int i = 0; i < n; i++) {
            if (ds[i].tuoi > 25) {
                ds[i].xuat((t + 1));
            }
        }
        System.out.println("Tong so sinh vien > 25 tuoi:" + t);
    }

    void svkha() {
        int dem = 0;
        System.out.println("***Danh sach sinh vien kha***");
                System.out.println("stt  " + "Ma sinh vien" + "   " + "Ho ten" + "               " + "Tuoi" + "   " + "Diem trung binh");

        for (int i = 0; i < n; i++) {
            if (ds[i].dtb > 7) {
                ds[i].xuat((dem + 1));
            }
        }
        System.out.println("Tong so sinh vien kha:" + dem);
    }

    void sapxep() {
        Danhsachsv tg = new Danhsachsv();
        System.out.println("***danh sach sinh vien sap xep theo ma sv***");
        
        System.out.println("stt  " + "Ma sinh vien" + "   " + "Ho ten" + "               " + "Tuoi" + "   " + "Diem trung binh");

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (ds[i].masv > ds[j].masv) {
                    tg = ds[i];
                    ds[i] = ds[j];
                    ds[j] = tg;
                }
            }
        }
        for (int i = 0; i < n; i++) {
            ds[i].xuat((i + 1));
        }

    }

    public static void main(String[] args) throws IOException {
        dssv x = new dssv();
        x.nhapds();
        x.xuatds();
        x.tuoi25();
        x.svkha();
        x.sapxep();
    }

}
