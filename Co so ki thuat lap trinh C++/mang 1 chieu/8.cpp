#include <iostream>
using namespace std;

int main()
{
    int n;
    int a[100];
    int x;

    // Nhập số lượng phần tử
    cout << "Nhap so luong phan tu: ";
    cin >> n;

    // Nhập giá trị cho các phần tử của mảng đã sắp xếp tăng dần
    cout << "Nhap gia tri cho cac phan tu da sap xep tang dan:\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = ";
        cin >> a[i];
    }

    // Nhập phần tử mới cần chèn
    cout << "Nhap phan tu can chen: ";
    cin >> x;

    // Chèn phần tử mới vào dãy đã sắp xếp
    int i = n - 1; // bắt đầu so sánh từ phần tử cuối cùng của dãy
    while (i >= 0 && a[i] > x) {
        a[i+1] = a[i]; // dịch phần tử sang phải để làm chỗ cho phần tử mới
        i--;
    }
    a[i+1] = x; // chèn phần tử mới vào vị trí thích hợp

    // In ra dãy số sau khi chèn phần tử mới
    cout << "Day so sau khi chen phan tu la:\n";
    for (int i = 0; i <= n; i++) {
        cout << "a[" << i << "] = " << a[i] << endl;
    }

    return 0;
}
