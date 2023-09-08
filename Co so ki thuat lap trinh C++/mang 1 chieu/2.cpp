#include <iostream>
using namespace std;

int main()
{
    int n;
    int a[100];

    // Nhập số lượng phần tử của mảng
    cout << "Nhap so phan tu cua mang (n < 100): ";
    cin >> n;

    // Nhập giá trị cho các phần tử của mảng
    cout << "Nhap gia tri cho cac phan tu cua mang:\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = ";
        cin >> a[i];
    }

    // Tìm phần tử có giá trị nhỏ nhất trong mảng
    int min_val = a[0];
    int min_pos = 0;
    for (int i = 1; i < n; i++) {
        if (a[i] < min_val) {
            min_val = a[i];
            min_pos = i;
        }
    }

    // In ra vị trí và giá trị của phần tử có giá trị nhỏ nhất trong mảng
    cout << "\nPhan tu co gia tri nho nhat la a[" << min_pos << "] = " << min_val << endl;

    return 0;
}
