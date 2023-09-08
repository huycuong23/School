#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	char a[100];
	cout<<"nhap xau a:";
	cin.getline(a,100);
    char b[100];
	cout<<"\nnhap xau b";
	cin.getline(b,100);
	if(strcmp(a,b)==0)
	{
		cout<<"hai chuoi a,b bang nhau";
	 } 
	 else if(strcmp(a,b)>0)
	 {
	 	cout<<"xau a lon hon xau b";
	 }
	 else
	 {
	 	cout<<"xau b lon hon xau a";
	 }

	return 0;
}
