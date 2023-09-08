#include <iostream>
using namespace std;

int main()
{
    int n, sum = 0, x;
    float average;

    cout << "Nhap so phan tu cua day: ";
    cin >> n;

    for (int i = 0; i < n; i++) {
        cout << "Nhap phan tu thu " << i + 1 << ": ";
        cin >> x;
        sum += x;
    }

    average = (float) sum / n;

    cout << "Tong cua day la: " << sum << endl;
    cout << "Trung binh cong cua day la: " << average << endl;

    return 0;
}
