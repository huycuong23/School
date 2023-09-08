#include <iostream>
using namespace std;
void traodoi(int &a, int &b)
{
    int tg = a;
    a = b;
    b = tg;
}
void noibot(int a[100], int n)
{
    int i, j;
    for (i = n-1; i >= 0; i--)
    {
        for (j = 0; j < i; j++)
        {
            if (a[j] > a[j+1])
            {
                traodoi(a[j], a[j+1]);
            }
        }
    }
}
int main()
{
    int a[100];
    int i, j;
    int n;
    cout << "nhap so phan tu ";
    cin >> n;
    for (i = 0; i < n; i++)
    {
        cout << "nhap phan tu so " << i + 1 << " ";
        cin >> a[i];
    }
    noibot(a, n);
    for (i = 0; i < n; i++)
    {
        cout << a[i] << " ";
    }
}