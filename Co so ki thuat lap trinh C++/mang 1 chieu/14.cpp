#include <iostream>
using namespace std;

void mergeArrays(int arr1[], int arr2[], int n1, int n2, int arr3[]) {
    int i = 0, j = 0, k = 0;

    // trộn hai mảng vào mảng thứ 3
    while (i < n1 && j < n2) {
        if (arr1[i] < arr2[j])
            arr3[k++] = arr1[i++];
        else
            arr3[k++] = arr2[j++];
    }

    // Copy các phần tử còn lại của arr1 (nếu có)
    while (i < n1)
        arr3[k++] = arr1[i++];

    // Copy các phần tử còn lại của arr2 (nếu có)
    while (j < n2)
        arr3[k++] = arr2[j++];
}

int main() {
    int arr1[] = {1, 3, 5, 7, 9};
    int n1 = sizeof(arr1) / sizeof(arr1[0]);

    int arr2[] = {2, 4, 6, 8, 10};
    int n2 = sizeof(arr2) / sizeof(arr2[0]);

    int arr3[n1 + n2];

    mergeArrays(arr1, arr2, n1, n2, arr3);

    // In ra mảng sau khi trộn
    cout << "Mang sau khi tron: ";
    for (int i = 0; i < n1 + n2; i++)
        cout << arr3[i] << " ";

    return 0;
}
