#include<iostream>
#include<string.h>
using namespace std;
void tach( char *s) 
{
  char *t;
  int i;
  for(i=strlen(s)-1;i>=0;i--)
  if(s[i]==' '&&s[i+1]!=' ')
  break;
  t=s+i+1;
  s[i]='\0';
  cout<<"ten: ";
  puts(t);
}

int main()
{
     char d[100];
	 cout<<"nhap vao ten can tach ten:";
	 cin.getline(d,100);
	 tach(d);
	return 0;
	return 0;
}
