#include <iostream>
#include <string.h>
#include <math.h>
using namespace std;
class D2
{
	float x, y;

public:
	D2(float = 0, float = 0);
	float congtoadox(D2);
	float congtoadoy(D2);
	float trutoadox(D2);
	float trutoadoy(D2);
	float getx();
	float gety();
	void setx(float);
	void sety(float);
	friend ostream &operator<<(ostream &, D2 &);
	friend istream &operator>>(istream &, D2 &);
};
class D3 : public D2
{
	float z;

public:
	D3(float = 0, float = 0, float = 0);
	float trutoadoz(D3);
	void setz(float);
	friend ostream &operator<<(ostream &, D3 &);
	friend istream &operator>>(istream &, D3 &);
};
D2::D2(float ox, float oy)
{
	x = ox;
	y = oy;
}
float D2::congtoadox(D2 a)
{
	return a.x + x;
}
float D2::congtoadoy(D2 a)
{
	return a.y + y;
}
float D2::trutoadox(D2 a)
{
	return a.x - x;
}
float D2::trutoadoy(D2 a)
{
	return a.y - y;
}
float D2::getx()
{
	return x;
}
float D2::gety()
{
	return y;
}
void D2::setx(float a) { x = a; }
void D2::sety(float a) { y = a; }
D3::D3(float ox, float oy, float oz) : D2(ox, oy) { z = oz; }
float D3::trutoadoz(D3 a)
{
	return a.z - z;
}
void D3::setz(float a) { z = a; }
istream &operator>>(istream &Input, D2 &P)
{
	cout << "Toa do x=";
	Input >> P.x;
	cout << "Toa do y=";
	Input >> P.y;
	return Input;
}
ostream &operator<<(ostream &Out, D2 &P)
{
	Out << "Toa do x=" << P.x << ", Toa do y=" << P.y;
	return Out;
}
istream &operator>>(istream &Input, D3 &P)
{
	float a, b;
	cout << "Toa do x=";
	Input >> a;
	cout << "Toa do y=";
	Input >> b;
	P.setx(a);
	P.sety(b);
	cout << "Toa do z=";
	Input >> P.z;
	return Input;
}
ostream &operator<<(ostream &Out, D3 &P)
{
	D2 Q = P;
	Out << Q << ", Toa do z=" << P.z;
	return Out;
}
int main()
{
	D2 A[10];
	D3 B[10];
	D2 C[10];
	D2 D[10];
	D2 E[10];
	int m, n,k, i;
	cout << "Nhap so diem A m=";
	cin >> m;
	cout << "Nhap " << m << " diem A:\n";
	for (i = 0; i < m; i++)
	{
		cout << "A[" << i << "]:";
		cin >> A[i];
	}
	cout << "Nhap so diem B n=";
	cin >> n;
	cout << "Nhap " << m << " diem B:\n";
	for (i = 0; i < n; i++)
	{
		cout << "B[" << i << "]:";
		cin >> B[i];
	}
	cout << "Nhap so diem C k=";
	cin >> k;
	cout << "Nhap " << k << " diem c:\n";
	for (i = 0; i < k; i++)
	{
		cout << "C[" << i << "]:";
		cin >> C[i];
	}
	cout << "\nCac diem A:";
	for (i = 0; i < m; i++)
		cout << "\nA[" << i << "]:" << A[i];
	cout << "\nCac diem B:";
	for (i = 0; i < n; i++)
		cout << "\nB[" << i << "]:" << B[i];
		cout << "\nCac diem c:";
	for (i = 0; i < k; i++)
		cout << "\nc[" << i << "]:" << C[i];
	for (i = n; i < m + n; i++)
	{
		B[i].setx(A[i - n].getx());
		B[i].sety(A[i - n].gety());
		B[i].setz(0);
	}
	cout << "\nCac diem B gop:";
	for (i = 0; i < m + n; i++)
		cout << "\nB[" << i << "]:" << B[i];

	for (i = 0; i < m; i++) {
		D[i].setx(A[i].congtoadox(C[i].getx()));
		D[i].sety(A[i].congtoadoy(C[i].getx()));
	}
	cout << "\nCac diem D:";
	for (i = 0; i < k; i++)
		cout << "\nc[" << i << "]:" << D[i];
		

	for (i = 0; i < m; i++) {
		E[i].setx(A[i].trutoadox(C[i].getx()));
		E[i].sety(A[i].trutoadoy(C[i].getx()));
	}
	cout << "\nCac diem E:";
	for (i = 0; i < k; i++)
		cout << "\nc[" << i << "]:" << E[i];
}
