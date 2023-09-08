#include <iostream>

using namespace std;

// Hàm tính tích P = 1* 3 * 5 * … * (2n-1) bằng đệ quy
int tinhTichLe(int n) {
    if (n == 1) { // Trường hợp cơ sở: n = 1
        return 1;
    }
    else { // Trường hợp đệ quy: n > 1
        int tich = tinhTichLe(n - 1); // Gọi đệ quy để tính tích của (n-1) số đầu tiên
        tich *= (2*n - 1); // Nhân tích với số lẻ thứ n: (2n-1)
        return tich; // Trả về tích
    }
}

int main() {
    int n;
    cout << "Nhap vao mot so nguyen duong: ";
    cin >> n;

    // Tính tích P = 1* 3 * 5 * … * (2n-1) bằng đệ quy
    int tich = tinhTichLe(n);

    // In kết quả ra màn hình
    cout << "Tich cac so le tu 1 den 2n-1 la: " << tich << endl;

    return 0;
}
