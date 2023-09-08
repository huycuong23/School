#include <iostream>
using namespace std;

// Tìm UCLN của hai số nguyên dương m và n
int gcd(int m, int n) {
    if (n == 0) {
        return m;
    }
    return gcd(n, m % n);
}

// Tìm UCLN của ba số nguyên dương a, b, c
int gcd3(int a, int b, int c) {
    int temp = gcd(a, b);
    return gcd(temp, c);
}

int main() {
    int m, n, a, b, c;
    cout << "Nhap m, n: ";
    cin >> m >> n;
    cout << "UCLN cua m va n la: " << gcd(m, n) << endl;

    cout << "Nhap a, b, c: ";
    cin >> a >> b >> c;
    cout << "UCLN cua a, b, c la: " << gcd3(a, b, c) << endl;

    return 0;
}
