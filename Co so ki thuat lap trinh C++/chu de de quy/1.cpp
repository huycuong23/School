#include <iostream>

using namespace std;

// Hàm tính tổng S = 1 + 4 + 9 + ... + n^2 bằng đệ quy
int tinhTongBinhPhuong(int n) {
    if (n == 1) { // Trường hợp cơ sở: n = 1
        return 1;
    }
    else { // Trường hợp đệ quy: n > 1
        int tong = tinhTongBinhPhuong(n - 1); // Gọi đệ quy để tính tổng của n-1 số đầu tiên
        tong += n * n; // Cộng thêm số n^2 vào tổng
        return tong; // Trả về tổng
    }
}

int main() {
    int n;
    cout << "Nhap vao mot so nguyen duong: ";
    cin >> n;

    // Tính tổng S = 1 + 4 + 9 + ... + n^2 bằng đệ quy
    int tong = tinhTongBinhPhuong(n);

    // In kết quả ra màn hình
    cout << "Tong binh phuong cua " << n << " so dau tien la: " << tong << endl;

    return 0;
}
