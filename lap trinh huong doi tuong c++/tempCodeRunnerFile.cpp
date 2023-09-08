#include <iostream>
#include <string.h>
using namespace std;
class THISINH
{
    char hoten[50];
    int sobaodanh;
    float diemmon1, diemmon2, diemmon3;

public:
    THISINH(char *s, int, float, float, float);
    char *gethoten();
    int getsobaodanh();
    float getdiemmon1();
    float getdiemmon2();
    float getdiemmon3();
    void sethoten(char *);
    void setsobaodanh(int);
    void setdiemmon1(float);
    void setdiemmon2(float);
    void setdiemmon3(float);
    friend istream &operator>>(istream &, THISINH &);
    friend ostream &operator<<(ostream &, THISINH &);
};
THISINH::THISINH(char *s, int n, float m1, float m2, float m3)
{
    strcpy(hoten, s);
    sobaodanh = n;
    diemmon1 = m1;
    diemmon2 = m2;
    diemmon3 = m3;
}
char *THISINH::gethoten() { return hoten; }
int THISINH::getsobaodanh() { return sobaodanh; }
float THISINH::getdiemmon1() { return diemmon1; }
float THISINH::getdiemmon2() { return diemmon2; }
float THISINH::getdiemmon3() { return diemmon3; }
void THISINH::sethoten(char *s) { strcpy(hoten, s); }
void THISINH::setsobaodanh(int n) { sobaodanh = n; }
void THISINH::setdiemmon1(float m1) { diemmon1 = m1; }
void THISINH::setdiemmon2(float m2) { diemmon2 = m2; }
void THISINH::setdiemmon3(float m3) { diemmon3 = m3; }

istream &operator>>(istream &Input, THISINH &P)
{
    cout << "Ho ten: ";
    fflush(stdin);
    gets(P.hoten);
    cout << "Nam sinh: \n diem mon 1: \ndiem mon 2: \ndiem mon 3:";
    Input >> P.sobaodanh >> P.diemmon1 >> P.diemmon2 >> P.diemmon3;
    return Input;
}
ostream &operator<<(ostream &Out, THISINH &P)
{
    Out << endl
        << "Ho ten: " << P.hoten << ", Nam sinh: " << P.sobaodanh
        << "diem mon 1: " << P.diemmon1
        << "diem mon 2: " << P.diemmon2
        << "diem mon 3: " << P.diemmon3;
    return Out;
}

class SINHVIEN : public THISINH
{
    string nganhhoca;
    string nganhhocb;
    string nganhhocc;

public:
    SINHVIEN(char *s, int, float, float, float, string, string, string);
    void tinhhocphi();
    friend istream &operator>>(istream &, SINHVIEN &);
    friend ostream &operator<<(ostream &, SINHVIEN &);
}

int main()
{
    THISINH a[20];
    int m, i;
    cout << "Nhap so luong thi sinh m=";
    cin >> m;
    cout << "Nhap thong tin cua cac thi sinh:" << endl;
    for (i = 1; i <= m; i++)
    {
        cout << "Nguoi thu " << i << ":";
        cin >> a[i];
    }
    cout << "Danh sach thi sinh:" << endl;
    for (i = 1; i <= m; i++)
    {
        cout << "\nthi sinh thu " << i << ":";
        cout << a[i];
    }
    return 0;
}