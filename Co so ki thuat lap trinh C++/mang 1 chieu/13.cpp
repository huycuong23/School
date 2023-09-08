#include <iostream>
#include <cmath>

using namespace std;

// Hàm kiểm tra một số có phải là số nguyên tố hay không
bool isPrime(int n) {
    if (n < 2) return false;
    for (int i = 2; i <= sqrt(n); i++) {
        if (n % i == 0) return false;
    }
    return true;
}

int main() {
    int n;
    cout << "Nhap so phan tu cua mang: ";
    cin >> n;

    int a[n];
    cout << "Nhap cac phan tu cua mang:\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = ";
        cin >> a[i];
    }

    cout << "Cac so nguyen to trong mang la:\n";
    for (int i = 0; i < n; i++) {
        if (isPrime(a[i])) {
            cout << a[i] << " ";
        }
    }

    return 0;
}
