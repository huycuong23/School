#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	char a[100];
	cout<<"nhap xau a:";
	cin.getline(a,100);
	cout<<"\n do dai cua xau la:"<<strlen(a)<<endl;
	return 0;
}
