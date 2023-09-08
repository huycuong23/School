#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	char a[100];
	cout<<"nhap xau a:";
	cin.getline(a,100);
	cout<<"\n xau a sau khi dao nguoc la:"<<strrev(a)<<endl;
	return 0;
}
