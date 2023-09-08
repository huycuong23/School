#include <iostream>
#include <fstream>
#include <math.h>
using namespace std;
int giaiPT(float a, float b, float c, float &x1, float &x2)
{
	float delta = b * b - 4 * a * c;
	if (delta < 0)
	{
		x1 = x2 = 0.0;
		return 0;
	}
	else if (delta == 0)
	{
		x1 = x2 = -b / (2 * a);
		return 1;
	}
	else
	{
		delta = sqrt(delta);
		x1 = (-b + delta) / (2 * a);
		x2 = (-b - delta) / (2 * a);
		return 2;
	}
}
int main()
{
	ifstream input("in7.txt");
	int a, b, c;
	input >> a;
	input >> b;
	input >> c;
	float x1, x2;
	fstream output;
	output.open("out7.txt", ios::out);
	while (!a);
	int numNo = giaiPT(a, b, c, x1, x2);
	if (numNo == 0)
	{
		output << "Phuong trinh da cho vo nghiem";
	}
	else if (numNo == 1)
	{
		output << "Phuong trinh da cho co nghiem kep x=%.4f" << x1;
	}
	else
	{
		output << "Phuong trinh da cho co hai nghiem phan biet" << endl;
		output << "x1=" << x1 << endl;
		output << "x2=" << x2 << endl;
	}
output.close(); // đóng file output
return 0;
}
