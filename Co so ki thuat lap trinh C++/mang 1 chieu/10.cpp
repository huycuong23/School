#include <iostream>
using namespace std;

void selectionSort(int arr[], int n) {
    int i, j, min_idx;

    for (i = 0; i < n - 1; i++) {
        min_idx = i;
        for (j = i + 1; j < n; j++)
            if (arr[j] > arr[min_idx])
                min_idx = j;

        swap(arr[min_idx], arr[i]);
    }
}

int main() {
    int n, i;

    cout << "Nhap so phan tu cua mang: ";
    cin >> n;

    int arr[n];

    cout << "Nhap cac phan tu cua mang: ";
    for (i = 0; i < n; i++)
        cin >> arr[i];

    // In ra mang truoc khi sap xep
    cout << "Mang truoc khi sap xep: ";
    for (i = 0; i < n; i++)
        cout << arr[i] << " ";
    cout << endl;

    // Sap xep mang theo thu tu giam dan
    selectionSort(arr, n);

    // In ra mang sau khi sap xep
    cout << "Mang sau khi sap xep: ";
    for (i = 0; i < n; i++)
        cout << arr[i] << " ";
    cout << endl;

    return 0;
}
