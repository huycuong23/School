#include <iostream>
using namespace std;

int main()
{
    int n;
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

    // In ra các phần tử theo thứ tự ngược lại
    cout << "\nCac phan tu theo thu tu nguoc lai la:\n";
    for (int i = n - 1; i >= 0; i--) {
        cout << a[i] << " ";
    }
    cout << endl;

    return 0;
}
