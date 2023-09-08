#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	ifstream input("in8.txt");
	int a, b, c;
	input >> a;
	input >> b;
	input >> c;
	fstream output;
	output.open("out8.txt", ios::out);
	if (a <= 0 || b <= 0 || c <= 0) output << "canh phai lon hon 0";
  else {
    if (a + b > c || a + c > b || b + c > a) output << "khong phai 3 canh cua tam giac";
    else {
      if (a == b && b == c && a == c) output << "Tam giac deu";
      else {
        if (a == b || b == c || c == a) output << "Tam giac can";
        else {
          if (a * a + b * b == c * c || a * c + c * c == b * b || b * b + c * c == a * c) {
            output << "Tam giac vuong";
          } else output << "Tam giac thuong";
        }
      }
    }
  }
output.close(); // đóng file output
return 0;
}
