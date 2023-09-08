#include <iostream>
using namespace std;
class NGUOI
{
private:
    string hoten;
    int namsinh;

public:
    NGUOI()
    {
    }
    NGUOI(string hoten, int namsinh)
    {
        this->hoten = hoten;
        this->namsinh = namsinh;
    }
    void getNGUOI()
    {
        cout << this->hoten << endl;
        cout << this->namsinh;
    }
    void setNGUOI(string hoten, int namsinh)
    {
        if (namsinh > 0)
        {
            this->hoten = hoten;
            this->namsinh = namsinh;
        }
    }
    friend ostream &operator<<(ostream &out, const NGUOI &p);
    friend istream &operator>>(istream &in, NGUOI &p);
};
ostream &operator<<(ostream &out, const NGUOI &p)
{
    out << p.hoten << "," << p.namsinh;
    return out;
};
istream &operator>>(istream &in, NGUOI &p)
{
    in >> p.hoten >> p.namsinh;
    return in;
};
int main()
{
    NGUOI a[10];
    int n;
    cout << "Nhap so NGUOI: ";
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cout << "Nhap ho ten va nam sinh NGUOI"<<i+1<<": ";
        cin >> a[i];
    }
        cout << "cac NGUOI A vua nhap";
    for (int i = 0; i < n; i++)
    {
        cout<<"\nNGUOI A thu "<<i+1<<": "<<a[i];
    }
}