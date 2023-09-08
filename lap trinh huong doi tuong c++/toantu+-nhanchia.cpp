#include <iostream>
#include <conio.h>
#include <math.h>
using namespace std;
class Toado2D
{
private:
    int x, y;

public:
    Toado2D()
    {
        x = 0;
        y = 0;
    }
    Toado2D(int x, int y)
    {
        this->x = x;
        this->y = y;
    }
    void nhap();
    void hienthi() const;
    Toado2D operator+(Toado2D C);
    Toado2D operator-(Toado2D C);
    Toado2D operator+(int);
    Toado2D operator-(int);
    int operator==(Toado2D B);
    int operator<=(Toado2D B);
};
int Toado2D::operator<=(Toado2D B)
{
    if (this->x <= B.x
        &&this->y <= B.y) return (1);
    else
        return (0);
}
int Toado2D::operator==(Toado2D B)
{
    if (this->x == B.x
        &&this->y == B.y) return (1);
    else
        return (0);
}
Toado2D Toado2D::operator+(Toado2D C)
{
    Toado2D A;
    A.x = this->x + C.x;
    A.y = this->y + C.y;
    return (A);
}
Toado2D Toado2D::operator-(Toado2D C)
{
    Toado2D A;
    A.x = this->x - C.x;
    A.y = this->y - C.y;
    return (A);
}
Toado2D Toado2D::operator+(int dx)
{
    Toado2D A;
    A.x = this->x + dx;
    A.y = this->y;
    return (A);
}
Toado2D Toado2D::operator-(int dx)
{
    Toado2D A;
    A.x = this->x - dx;
    A.y = this->y;
    return (A);
}
void Toado2D::nhap()
{
    cout << "nhap x, y: ";
    cin >> x >> y;
}
void Toado2D::hienthi() const
{
    cout << "(" << x << "," << y << ")";
}
int main()
{
    Toado2D A(10, 2), B(7, 3), C;
    cout << "\nA: ";
    A.hienthi();
    cout << "\nB: ";
    B.hienthi();
    C = A + B;
    cout << "\nC=A+B: ";
    C.hienthi();
    C = C + 5;
    cout << "\nC dich sang phai ";
    C.hienthi();
    C = C - 2;
    cout << "\nC dich sang trai ";
    C.hienthi();
    Toado2D D;
    D = C - B;
    cout << "\nD=C-B: ";
    D.hienthi();
    if (A == B)
        cout << "\nA=B";
    else
        cout << "\nA<>B";
    if (B <= C)
        cout << "\nB<=C";
    else
        cout << "\nB>C";
    getch();
}