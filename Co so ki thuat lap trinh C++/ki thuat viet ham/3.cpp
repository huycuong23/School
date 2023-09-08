#include <iostream>
#include <iomanip>
using namespace std;
struct GV{
    // khong the truy xuat ngoai class
    string mgv, ht, gt, qq;
    // mgv: ma giang vien, ht: ho ten
    // gt: gioi tinh, qq: que quan
    int tuoi;
};

GV nhap(){
    GV a;
    cout << "Ma giang vien: ";
    getline(cin, a.mgv);
    cout << "Ho ten: ";
    getline(cin, a.ht);
    cout << "Tuoi: ";
    cin >> a.tuoi;
    cin.ignore();// xoa bo nho tranh loi trung dong khi chuyen tu nhap chu sang nhap so
    cout << "Gioi tinh: ";
    getline(cin, a.gt);
    cout << "Que quan: ";
    getline(cin, a.qq);  
    return a; 
}

void xuat(GV a){
    cout << '|' << setw(20) << a.mgv; // setw(n) tao ra 1 khoang trong chua n ki tu
    cout << '|' << setw(25) << a.ht;
    cout << '|' << setw(10) << a.tuoi;
    cout << '|' << setw(10) << a.gt;
    cout << '|' << setw(20) << a.qq << '|' << endl;
    cout << '|' << setfill('=') << setw(90) << '|' << setfill(' ') << endl;// setfill thay doi ki tu mac dinh
}

void tieu_de(){// tao de muc cho bang
    cout << '|' << setfill('=') << setw(90) << '|' << setfill(' ') << endl;
    cout << '|' << setw(20) << "Ma giao vien";
    cout << '|' << setw(25) << "Ho ten";
    cout << '|' << setw(10) << "Tuoi";
    cout << '|' << setw(10) << "Gioi tinh";
    cout << '|' << setw(21) << "Que quan|" << endl;
    cout << '|' << setfill('=') << setw(90) << '|' << setfill(' ') << endl;
}

void xoa(GV gv[], int &n){
    int k;
    cout << "Thu tu giang vien muon xoa: "; cin >> k;   
    cin.ignore();

    for (int i = k - 1; i < n - 1; i++){// ghi de du lieu cua giang vien can xoa
        gv[i] = gv[i + 1];
    }
    n--;

    cout << "\n\t\t\t\tDanh sach giang vien da xoa" << endl;
    tieu_de();
    for (int i = 0; i < n; i++){
        xuat(gv[i]);
    }
}

void them(GV gv[], int &n){
    cout << "\n\tThong tin nguoi can them" << endl;
    gv[n] = nhap();// vi mang danh dau tu 0 den n - 1
    n++;

    cout << "\n\t\t\t\tDanh sach giang vien da them" << endl;
    tieu_de();
    for (int i = 0; i < n; i++){
        xuat(gv[i]);
    }
}

void suatt(GV gv[], int n){
    int k;
    cout << "Thu tu cua giang vien muon sua thong tin: " << endl;
    cin >> k;
    cin.ignore();

    gv[k - 1] = nhap();
    cout << "\n\t\t\t\tDanh sach giang vien da sua" << endl;
    tieu_de();
    for (int i = 0; i < n; i++){
        xuat(gv[i]);
    }
}

int main(){
    int n;
    cout << "So giang vien: ";
    cin >> n;
    cin.ignore();
    GV gv[n];// khai bao mang tinh voi kieu du lieu GV gom n giang vien

    for (int i = 0; i < n; i++){
        cout << "\n\tThong tin giang vien thu " << i + 1 << endl;
        gv[i] = nhap();// goi den thuoc tinh nhap cua doi tuong gv[i]
    }

    cout << "\n\t\t\t\tDanh sach giang vien da nhap" << endl;
    tieu_de();
    for (int i = 0; i < n; i++){
        xuat(gv[i]);
    }

    //xoa
    xoa(gv, n);
    //them
    them(gv, n);
    //sua thong tin
    suatt(gv, n);
    return 0;
}
