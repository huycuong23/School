#include <iostream>
#include <conio.h>
using namespace std;
class Toado2D
{
private:
    double x, y;

public:
    Toado2D()
    {
        x = 0;
        y = 0;
    }
    Toado2D(double x, double y)
    {
        this->x = x;
        this->y = y;
    }
    friend ostream &operator<<(ostream &out, const Toado2D &p);
    friend istream &operator>>(istream &in, Toado2D &p);
};
ostream &operator<<(ostream &out, const Toado2D &p)
{
    out << "(" << p.x << "," << p.y << ")";
    return out;
};
istream &operator>>(istream &in, Toado2D &p)
{
    cin >> p.x >> p.y;
    return in;
};
int main()
{
    Toado2D A;
    cout << "\nNhap diem A: ";
    cin >> A;
    cout << "\nToa do vua nhap A: ";
    cout << A;
    getch();
    return 0;
}