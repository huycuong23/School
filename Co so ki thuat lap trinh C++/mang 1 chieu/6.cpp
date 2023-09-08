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

    // In ra các giá trị khác nhau của dãy số
    cout << "\nCac gia tri khac nhau trong day so la:\n";
    for (int i = 0; i < n; i++) {
        bool isDuplicate = false; // biến kiểm tra xem a[i] đã xuất hiện trước đó chưa
        for (int j = 0; j < i; j++) {
            if (a[i] == a[j]) {
                isDuplicate = true;
                break;
            }
        }
        if (!isDuplicate) {
            cout << a[i] << " ";
        }
    }
    cout << endl;

    return 0;
}
