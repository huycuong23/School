#include <iostream>
#include <string.h>
using namespace std;
class SANPHAM
{
private:
    int masp;
    string tensp;
    int namsx;

public:
    SANPHAM()
    {
        this->masp = 20;
        this->tensp = "khong";
        this->namsx = 2003;
    }
    SANPHAM(int masp, string tensp, int namsx)
    {
        this->masp = masp;
        this->tensp = tensp;
        this->namsx = namsx;
    }
    void getSANPHAM()
    {
        cout << this->masp << endl;
        cout << this->tensp << endl;
        cout << this->namsx;
    }
    void setSANPHAM(int masp, string tensp, int namsx)
    {
        if (namsx > 0 && masp > 0)
        {
            this->masp = masp;
            this->tensp = tensp;
            this->namsx = namsx;
        }
    }
    friend ostream &operator<<(ostream &out, const SANPHAM &p);
    friend istream &operator>>(istream &in, SANPHAM &p);
};
ostream &operator<<(ostream &out, const SANPHAM &p)
{
    out << p.masp << "," << p.tensp << "," << p.namsx;
    return out;
};
istream &operator>>(istream &in, SANPHAM &p)
{
    in >> p.masp >> p.tensp >> p.namsx;
    return in;
};
class TIVI : public SANPHAM
{
private:
    int chieudai;
    int chieurong;

public:
    TIVI() : SANPHAM(){};
    TIVI(int chieudai, int chieurong) : SANPHAM(masp, tensp, namsx)
    {
        this->chieudai = chieudai;
        this->chieurong = chieurong;
    }
    friend ostream &operator<<(ostream &out, TIVI &p);
    friend istream &operator>>(istream &in, TIVI &p);
};
ostream &operator<<(ostream &out, TIVI &p)
{
    out << p.chieudai << ", " << p.chieurong << "," << p.namsx << ", " << p.tensp << ", " << p.namsx;
    return out;
}
istream &operator>>(istream &in, TIVI &p)
{
    in >> p.loaiSANPHAM >> p.trongtai >> p.tensp >> p.namsx;
    return in;
}
int main()
{
    SANPHAM a[10];
    int n;
    cout << "Nhap so SANPHAM: ";
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cout << "Nhap masp, hang san xuat va nam san xuat SANPHAM " << i + 1 << ": ";
        cin >> a[i];
    }
    cout << a[0];
    cout << a[1];
}