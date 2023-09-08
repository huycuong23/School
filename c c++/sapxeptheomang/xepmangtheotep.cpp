#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    ifstream input; // tao ra mot tep o cung tm voi tep .cpp
    ofstream output;
    input.open("input.txt");
    output.open("output.txt");
    int a[100], i;
    int n = 0;
    // doc du lieu tu file
    while (input >> a[n])
        n++;
    // dong tep input
    input.close();
    // sapxep(a, n); // sắp xếp trước khi ghi vào tệp output
    // ghi tep
    for (i = 0; i < n; i++)
    {
        output << a[i] << " ";
    }
    // dong tep output
    output.close();
    return 0;
}