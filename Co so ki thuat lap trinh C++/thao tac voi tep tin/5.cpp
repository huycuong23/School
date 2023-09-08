#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	int n = 100;
	fstream output;
	output.open("sole.txt", ios::out);
	for (int i = 1; i <= n; i = i + 2)
	{
		output << i << ", ";
	}
	output.close(); // đóng file output
	return 0;
}
