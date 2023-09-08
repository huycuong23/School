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

    // Tìm số lớn nhất trong dãy số
    int max = a[0]; // giả sử a[0] là số lớn nhất ban đầu
    int pos = 0; // vị trí của số lớn nhất ban đầu là 0
    for (int i = 1; i < n; i++) {
        if (a[i] > max) {
            max = a[i];
            pos = i;
        }
    }

    // In ra số lớn nhất và vị trí của nó
    cout << "So lon nhat trong day so la " << max << " va no o vi tri " << pos << endl;

    return 0;
}
