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

    // Sắp xếp mảng theo thứ tự tăng dần
    for (int i = 0; i < n - 1; i++) {
        for (int j = i + 1; j < n; j++) {
            if (a[i] > a[j]) {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }

    // In ra mảng trước khi sắp xếp
    cout << "\nMang truoc khi sap xep: ";
    for (int i = 0; i < n; i++) {
        cout << a[i] << " ";
    }

    // In ra mảng sau khi sắp xếp
    cout << "\nMang sau khi sap xep: ";
    for (int i = 0; i < n; i++) {
        cout << a[i] << " ";
    }

    return 0;
}
