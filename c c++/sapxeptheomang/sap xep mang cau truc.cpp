#include <iostream>
using namespace std;
struct sinhvien
{
    char maso[10], tensv[30];
    float dtb;
};
void traodoi(sinhvien &sv1, sinhvien &sv2)
{
    sinhvien tg;
    tg = sv1;
    sv1 = sv2;
    sv2 = tg;
};
int main()
{
    sinhvien sv[100];
    int i, j, n, vtrimin;
    float min;
    cout << "nhap so sinh vien :";
    cin >> n;
    for (i = 0; i < n; i++)
    {
        cout << "nhap thong tin sinh vien thu :" << i + 1 << "\n";
        cout << "nhap ma sinh vien "
             << "\t";
        fflush(stdin);
        cin.get(sv[i].maso, 10);
        cout << "nhap ten sv "
             << "\t";
        fflush(stdin);
        cin.get(sv[i].tensv, 30);
        cout << "nhap diem tb "
             << "\t";
        cin >> sv[i].dtb;
    };
    for (i = 0; i < n - 1; i++)
    {
        min = sv[i].dtb;
        vtrimin = i;
        for (j = i; j < n; j++)
        {
            if (sv[j].dtb < min)
            {
                min = sv[j].dtb;
                vtrimin = j;
            }
            traodoi(sv[i], sv[vtrimin]);
        }
    }
    cout << "dssv sau khi duoc sap xep" << endl;
    for (i = 0; i < n; i++)
    {
        cout << "ma sv: " << sv[i].maso << "\n"
             << "ho ten: " << sv[i].tensv << "\n"
             << "diem trung binh: " << sv[i].dtb << endl
             << endl;
    }
    return 0;
};