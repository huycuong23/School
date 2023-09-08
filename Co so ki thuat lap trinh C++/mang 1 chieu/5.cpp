#include <iostream>
using namespace std;

int main()
{
    int n, k;
    int a[100];

    // Nhập số lượng phần tử
    cout << "Nhap so luong phan tu: ";
    cin >> n;

    // Nhập giá trị cho các phần tử của mảng
    cout << "Nhap gia tri cho cac phan tu:\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = ";
        cin >> a[i];
    }

    // Nhập vị trí cần xóa
    cout << "Nhap vi tri can xoa (1 <= k <= " << n << "): ";
    cin >> k;

    // Xóa phần tử tại vị trí k
    for (int i = k - 1; i < n - 1; i++) {
        a[i] = a[i+1];
    }
    n--;

    // In ra mảng sau khi xóa
    cout << "\nMang sau khi xoa phan tu tai vi tri " << k << ":\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = " << a[i] << endl;
    }

    return 0;
}
