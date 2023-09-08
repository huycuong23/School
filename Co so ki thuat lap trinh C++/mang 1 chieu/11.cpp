#include <iostream>
using namespace std;

int main() {
    int n, x;
// nhập giá trị của mảng và x
    cout << "Nhap so phan tu cua mang: ";
    cin >> n;

    int a[n];
    cout << "Nhap cac phan tu cua mang: ";
    for(int i = 0; i < n; i++) {
        cin >> a[i];
    }

    cout << "Nhap gia tri x can tim: ";
    cin >> x;
// duyệt qua từng phần tử trong mảng
    bool found = false;
    cout << "Cac phan tu co gia tri bang " << x << " co o vi tri: ";
    for(int i = 0; i < n; i++) {
        if(a[i] == x) {
            cout << i << " ";
            found = true;
        }
    }

    if(!found) {
        cout << "Khong tim thay phan tu nao co gia tri bang " << x;
    }

    return 0;
}
