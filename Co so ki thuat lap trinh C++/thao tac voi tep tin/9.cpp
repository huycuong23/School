#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    ifstream input; // tao ra mot tep o cung tm voi tep .cpp
    input.open("input.dat");
    int a[100], i;
    int n = 0;
    // doc du lieu tu file
    while (input >> a[n])
        n++;
    // dong tep input
    input.close();
    for (i = 0; i < n; i++)
    {
        cout << a[i] << " ";
    }
    return 0;
}
