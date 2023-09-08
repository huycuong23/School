#include <iostream>

bool isTriangle(int a, int b, int c) {
    // Kiểm tra điều kiện tạo thành tam giác
    if (a + b > c && a + c > b && b + c > a) {
        return true;
    } else {
        return false;
    }
}

int main() {
    int a, b, c;

    // Nhập ba số từ bàn phím
    std::cout << "Nhap ba so nguyen: ";
    std::cin >> a >> b >> c;

    // Kiểm tra xem ba số này có tạo thành tam giác hay không
    if (isTriangle(a, b, c)) {
        std::cout << "Ba so " << a << ", " << b << ", " << c << " tao thanh tam giac.";
    } else {
        std::cout << "Ba so " << a << ", " << b << ", " << c << " khong tao thanh tam giac.";
    }

    return 0;
}
