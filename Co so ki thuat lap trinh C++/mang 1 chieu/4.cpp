#include <iostream>
using namespace std;

int main()
{
    int n;
    int a[100];
    int sum = 0;

    // Nhập số lượng phần tử
    cout << "Nhap so luong phan tu: ";
    cin >> n;

    // Nhập giá trị cho các phần tử của mảng
    cout << "Nhap gia tri cho cac phan tu:\n";
    for (int i = 0; i < n; i++) {
        cout << "a[" << i << "] = ";
        cin >> a[i];
    }

    // Tính tổng các số lẻ trong dãy
    for (int i = 0; i < n; i++) {
        if (a[i] % 2 != 0) {
            sum += a[i];
        }
    }

    // In ra tổng các số lẻ trong dãy
    cout << "\nTong cac so le trong day la: " << sum << endl;

    return 0;
}
