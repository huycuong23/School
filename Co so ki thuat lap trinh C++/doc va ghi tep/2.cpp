#include <iostream>
#include <fstream>
using namespace std;
int gcd(int a, int b){
    // Nếu a = 0 => ucln(a,b) = b
    // Nếu b = 0 => ucln(a,b) = a
    if (a == 0 || b == 0){
        return a + b;
    }
    while (a != b){
        if (a > b){
            a -= b; // a = a - b
        }else{
            b -= a;
        }
    }
    return a; // return a or b, bởi vì lúc này a và b bằng nhau
}
int main()
{
	ifstream input("input.txt");
	int a, b;
	input>>a;
	input>>b;
	cout<<a<<", "<<b;
	int ucln = gcd(a,b);
	fstream output;
	output.open("output.txt", ios::out);
	
		output <<  "ucln cua 2 so la : "<< ucln;
	output.close(); // đóng file output
	return 0;
}
