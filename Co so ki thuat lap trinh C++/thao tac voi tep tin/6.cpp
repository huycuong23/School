#include <iostream>
#include <fstream>
using namespace std;
int max(int a, int b, int c){
	int max = a;
    if (max < b) max = b;
	if (max < c) max = c;
    return max;
}
int main()
{
	ifstream input("in6.txt");
	int a, b, c;
	input>>a;
	input>>b;
	input>>c;
	cout<<a<<", "<<b<<", "<<c<<endl;
	int max3 = max(a,b,c);
	fstream output;
	output.open("out6.txt", ios::out);
	output <<  "so lon nhat 3 so la : "<< max3;
	output.close(); // đóng file output
	return 0;
}
