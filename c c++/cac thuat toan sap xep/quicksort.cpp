#include <iostream>
using namespace std;
void traodoi(int &a, int &b)
{
    int tg = a;
    a = b;
    b = tg;
}

void quicksort(int a[100], int left, int right)
{
    int phanhoach = a[(left + right)/2];
    int l = left, r = right;
    while (l < r) {
        while (a[l] < phanhoach) l++;
        while (a[r] > phanhoach) r--;
        if (l <= r) {
            traodoi(a[l], a[r]);
            l++;
            r--;
        }
        
    };
    if (left < r) quicksort(a, left, r);
    if (right > l)  quicksort(a, l, right);
}
int main()
{
    int a[100];
    int n;
    int i,j;
    cout << "nhap so phan tu ";
    cin >> n;
    for (i = 0; i < n; i++)
    {
        cout << "nhap phan tu so " << i + 1 << " ";
        cin >> a[i];
    }
    quicksort(a, 0, n - 1);
    for (i = 0; i < n; i++)
    {
        cout << a[i] << " ";
    }
    return 0;
}