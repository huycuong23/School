#include <iostream>
#include <cmath>
// Sử dụng vòng lặp để kiểm tra n có chia hết trong khoảng từ 2 đến căn bậc 2 không
bool isPrime(int n) {
    if (n <= 1) {
        return false;
    }

    for (int i = 2; i <= sqrt(n); i++) {
        if (n % i == 0) {
            return false;
        }
    }

    return true;
}

int main() {
    int n;

    // Nhập giá trị của n từ bàn phím
    std::cout << "Nhap n: ";
    std::cin >> n;

    // Tìm và in ra các số nguyên tố trong khoảng từ 2 đến n
    std::cout << "Cac so nguyen to trong khoang tu 2 den " << n << " la:\n";
    for (int i = 2; i <= n; i++) {
        if (isPrime(i)) {
            std::cout << i << " ";
        }
    }

    return 0;
}
