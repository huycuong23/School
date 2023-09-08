#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	char a[100];
	cout<<"nhap xau a:";
	cin.getline(a,100);
	cout<<"\n in ra thành chu hoa là :"<<strupr(a);
	return 0;
}
