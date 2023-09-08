#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;

int main()
{
    ifstream input; // tao ra mot tep o cung tm voi tep .cpp
    input.open("input2.dat");
    char a[50];
    // doc du lieu tu file
    input.read(a, 50);
    // dong tep input
    input.close();
    cout << strrev(a);
    return 0;
}
