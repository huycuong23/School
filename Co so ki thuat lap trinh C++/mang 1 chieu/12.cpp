#include <iostream>
using namespace std;

// Hàm kiểm tra xem một số có phải là số hoàn hảo không
bool checkPerfectNumber(int n) {
    int sum = 0;
    for (int i = 1; i < n; i++) {
        if (n % i == 0) {
            sum += i;
        }
    }
    return sum == n;
}

// Hàm tìm và in ra các số hoàn hảo trong mảng
void findPerfectNumbers(int arr[], int n) {
    cout << "Các số hoàn hảo trong mảng: ";
    for (int i = 0; i < n; i++) {
        if (checkPerfectNumber(arr[i])) {
            cout << arr[i] << " ";
        }
    }
    cout << endl;
}

int main() {
    int n;
    cout << "Nhap so phan tu cua mang: ";
    cin >> n;

    int arr[n];
    cout << "Nhap cac phan tu cua mang: ";
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    // Tìm và in ra các số hoàn hảo trong mảng
    findPerfectNumbers(arr, n);

    return 0;
}
