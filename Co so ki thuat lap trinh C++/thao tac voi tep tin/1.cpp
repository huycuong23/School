#include <iostream>
#include <fstream>
using namespace std;
int chan(int a){
    if (a % 2 == 0) return 1;
	else return 0;
}
int main()
{
	int a;
	cout << "nhap 1 so nguyen duong: ";cin >> a;
	int p = chan(a);
	fstream output;
	output.open("output.txt", ios::out);
	if (p == 1){
		output <<  "so vua nhap la so chan";
	}
	else output << "so vua nhap la so le";
	output.close(); // đóng file output
	return 0;
}
